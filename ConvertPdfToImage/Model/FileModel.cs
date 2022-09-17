namespace ConvertPdfToImage.Model
{
	public class FileModel
	{
		private readonly string folderPath;

		private readonly string fileName;

		public FileModel(string folderPath, string fileName)
		{
			this.folderPath = folderPath;
			this.fileName = fileName;
		}

		public string GetFolderPath() => folderPath;

		public string GetFileName() => fileName;
	}
}