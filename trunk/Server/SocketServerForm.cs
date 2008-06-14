using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace beginSocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //SET UP SOCKET AND SET IN LISTENING MODE
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 8221);
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sock.Bind(ipEnd);
            sock.Listen(100);

            //INIFINITE LOOP TO ENSURE PROGRAM IS ALWAYS LISTENING WHEN NOT TRANSFERRING
            while(true)
            {
                try
                {
                    //ACCEPTS THE CONNECTION WHEN FOUND                  
                    Socket clientSock = sock.Accept();

                    //INIT VARS
                    int bytesReceived = 0;
                    string receivedPath = "C:\\Documents and Settings\\Jeremy\\Desktop\\Download\\";
                    byte[] buffer = new byte[1024];
                    int receivedBytesLen = 0;
                    byte[] fileInfo = new byte[1024];
                   
                    //DETERMINE FILE NAME AND FILE SIZE FROM FIRST TRANSMISSION             
                    clientSock.Receive(fileInfo);

                    int fileNameLen = BitConverter.ToInt32(fileInfo,0);
                    string fileName = Encoding.ASCII.GetString(fileInfo, 4, fileNameLen);
                    
                    int fileSizeLen = BitConverter.ToInt32(fileInfo, 4 + fileNameLen);
                    
                    //string fileSizeString = Encoding.GetString(fileInfo, 8 + fileNameLen, fileSizeLen);                
                    int fileSize = BitConverter.ToInt32(fileInfo, 8 + fileNameLen);

                    //CREATE FILE TO SAVE
                    BinaryWriter bWrite = new BinaryWriter(File.Open(receivedPath + fileName, FileMode.Append)); 

                    //RECEIVE AND RECORD THE REST OF THE DATA FROM ALL PACKETS
                    while ((receivedBytesLen = clientSock.Receive(buffer)) != 0) 
                    {
                      bWrite.Write(buffer, 0, receivedBytesLen);
                      bytesReceived += receivedBytesLen;
                    }           
                   
                    //CLOSE FILE AND CONNECTION TO CLIENT
                    bWrite.Close();
                    clientSock.Close();

                    //IF FILE STOPPED IN THE MIDDLE OF SENDING DELETE THE FILE
                    if (bytesReceived != fileSize)
                    {
                        File.Delete(receivedPath + fileName);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in receiving file." + ex.Message);
                }
            }
        }
    }
}
