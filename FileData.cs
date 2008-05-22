﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;

namespace WindowsApplication1
{
    public class FileData
    {
        public string Path;
        public string Name;
        public string Extension;
        public double Size;
        public string fileType;

        public FileData() { }

        public FileData(string filePath)
        {
            Path = filePath;
            FileInfo FI = new FileInfo(Path);
            Name = FI.Name;
            Name = Name.Remove(Name.LastIndexOf('.'));
            Extension = Path.Substring(Path.LastIndexOf('.')+1);
            Size = Convert.ToDouble(FI.Length)/1048576.00;

            if ((FI.Extension == ".mp3") || (FI.Extension == ".m4a") || (FI.Extension == ".wav") || (FI.Extension == ".wma"))
                fileType = "Audio";
            else if ((FI.Extension == ".avi") || (FI.Extension == ".mov") || (FI.Extension == ".divx") || (FI.Extension == ".MP4"))
                fileType = "Video";
            else if ((FI.Extension == ".bmp") || (FI.Extension == ".jpg") || (FI.Extension == ".gif") || (FI.Extension == ".png") || (FI.Extension == ".tif") || (FI.Extension == ".jpeg") || (FI.Extension == ".JPG"))
                fileType = "Image";
            else
                fileType = "Invalid";
        }

        public override string ToString()
        {
            return Name;
        }

        public string GetFileSize()
        {
           return Size.ToString("0.00") + " MB";
        }

        public string GetFilePath()
        {
            return Path;
        }

        public string GetFileExtension()
        {
            return Extension;
        }

        public string GetFileType()
        {
            return fileType;
        }
    }
}
