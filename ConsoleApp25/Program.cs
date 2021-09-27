using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        public class MenuItem
        {
            public string Caption;
            public string HotKey;
            public MenuItem[] Items;
        }
		public static MenuItem[] GenerateMenu()
		{
			return new[]
			{
		new MenuItem
		{
			Caption = "File", HotKey="F", Items=new []
			{ new MenuItem {Caption = "New", HotKey="N", Items = null},
				new MenuItem {Caption = "Save", HotKey="S",  Items = null}
			}
		},
		new MenuItem
		{ 
			Caption = "Edit", HotKey="E", Items=new []
			 {
				new MenuItem {Caption = "Copy", HotKey="C", Items = null},
				new MenuItem {Caption = "Paste", HotKey="P", Items = null}
		 	}
		}
	};
		}
		public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
		{
			var result = new Dictionary<string, DirectoryInfo>();
			foreach (var item in files)
				if (item.Extension == ".wav" || item.Extension == ".mp3")
				{
					string path = item.DirectoryName;
					if (!result.ContainsKey(path))
						result.Add(path, item.Directory);
				}
			return result.Values.ToList<DirectoryInfo>();
		}
		static void Main(string[] args)
        {
        }
    }
}
