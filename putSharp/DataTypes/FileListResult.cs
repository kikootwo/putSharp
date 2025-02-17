﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace putSharp.DataTypes
{
    public class FileListResult
    {
        private List<Dictionary<string, object>> _files = new List<Dictionary<string, object>>();
        private Dictionary<string, object> _parentFile = new Dictionary<string, object>();
        private string _status = "";

        public List<Dictionary<string, object>> Files { get => _files; set => _files = value; }
        public Dictionary<string, object> ParentFile { get => _parentFile; set => _parentFile = value; }
        public string Status { get => _status; set => _status = value; }

        public List<File> GetFiles()
        {
            List<File> files = new List<File>();

            foreach (Dictionary<string, object> dictionary in _files)
            {
                File f = new File();
                f.Data = dictionary;
                f.Status = _status;
                files.Add(f);
            }

            return files;
        }

        public File GetParentFile()
        {
            File file = new File();
            file.Data = _parentFile;
            file.Status = _status;

            return file;
        }
    }
}