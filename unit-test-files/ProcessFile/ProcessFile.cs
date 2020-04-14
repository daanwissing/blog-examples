using System;
using System.IO;

namespace ProcessFile
{
    public class ProcessFile
    {
    	public ProcessResult Process(string fileName)
    	{
			if (!File.Exists(fileName)) 
				throw new ArgumentException($"File {fileName} does not exist", nameof(fileName));
			// Process file here...
    		return new ProcessResult(); 
    	}

    	public ProcessResult Process(Stream fileStream)
    	{
			if (!fileStream.CanRead)
				throw new ArgumentException("Stream cannot be read", nameof(fileStream));
			// Process stream here...
    		return new ProcessResult();
    	}
    }
}
