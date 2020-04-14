using System;
using System.IO;

namespace ProcessFile
{
    public class ProcessFile
    {
    	public ProcessResult Process(string fileName)
    	{
			// Process file here...
			if (!File.Exists(fileName)) 
				throw new ArgumentException($"File {fileName} does not exist", nameof(fileName));
    		return new ProcessResult(); 
    	}

    	public ProcessResult Process(Stream fileStream)
    	{
			// Process stream here...
			if (!fileStream.CanRead)
				throw new ArgumentException("Stream cannot be read", nameof(fileStream));
    		return new ProcessResult();
    	}
    }
}
