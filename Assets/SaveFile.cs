using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Diagnostics;

public class SaveFile : MonoBehaviour {
	public string FileSavePath; //D:\file.txt
	public string TextString;
	// Use this for initialization
	public void ReadFile (string DirectoryPath) {
		try
                {   // Open the text file using a stream reader.
                    using (StreamReader sr = new StreamReader(FilePath))
                    {
                        TextData = sr.ReadToEnd();
                    }
                }
                catch { };
	}
	
	public void OpenDirectory (string DirectoryPath) {
		Process.Start(DirectoryPath); 
	}

	public void OpenFile (string FilePath) {
		Process.Start("notepad.exe", FilePath); 
		//If you want to select the file or folder you can use the following:
		//Process.Start("explorer.exe", "/select, c:\\teste");
	}
	public void DeleteFile (string FilePath) {
		if(File.Exists(FilePath))
		{
			File.Delete(FilePath);
		}
	}

	public void CheckDirectory (string FilePath) {
		string Dir = Path.GetDirectoryName (FilePath);
		if (!Directory.Exists(Dir)) {
			Directory.CreateDirectory(Dir);
		}
	}

	void CheckFile (string FilePath) {
		if (!File.Exists(FilePath)) {
			// Create a file to write to.
			using (StreamWriter sw = File.CreateText(FileSavePath)) 
			{
				sw.WriteLine("");
			}	
		}
	}

	public void File_WriteAllText () {
		CheckDirectory (FileSavePath);
		System.IO.File.WriteAllText(FileSavePath, TextString);
	}

	public void File_WriteAllText (string FilePath, string FileText) {
		CheckDirectory (FilePath);
		System.IO.File.WriteAllText(FilePath, FileText);
	}

	public void File_AppendText () {
		CheckDirectory (FileSavePath);
		using (StreamWriter sw = File.AppendText(FileSavePath))
		{
			sw.WriteLine(TextString);
		}
	}

	public void File_AppendText (string FilePath, string AppendString) {
		CheckDirectory (FilePath);
		using (StreamWriter sw = File.AppendText(FilePath))
		{
			sw.WriteLine(AppendString);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
