<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<dx:ASPxFileManager ID="ASPxFileManager1" runat="server" CustomFileSystemProviderTypeName="CustomFileProvider" >
				<Settings RootFolder="~/Folder/" ThumbnailFolder="~/Thumb/" />
				<SettingsUpload Enabled="false" />
				<SettingsFileList ShowFolders="true"></SettingsFileList>
			</dx:ASPxFileManager>
		</div>
	</form>
</body>
</html>
