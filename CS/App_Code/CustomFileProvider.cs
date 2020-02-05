using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

public class CustomFileProvider : PhysicalFileSystemProvider {
	public CustomFileProvider(string rootFolder)
		: base(rootFolder) { }
	
	public override IEnumerable<FileManagerFolder> GetFolders(FileManagerFolder parentFolder) {
		List<FileManagerFolder> folders = new List<FileManagerFolder>(base.GetFolders(parentFolder));
		return folders.OrderByDescending(a => a.Name);
	}
}
