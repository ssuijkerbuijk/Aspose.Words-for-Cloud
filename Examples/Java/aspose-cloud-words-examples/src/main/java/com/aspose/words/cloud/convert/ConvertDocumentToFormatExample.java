package com.aspose.words.cloud.convert;

import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.ResponseMessage;

public class ConvertDocumentToFormatExample {

	public static void main(String... argc) {
		// ExStart: ConvertDocumentToFormatExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, false);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, false);

			// set input file name
			String fileName = "SampleWordDocument.docx";

			// set the desire output format
			String format = "html";
			String storage = "";
			String folder = "";
			String outPath = "";
			
			//Path p1=Utils.getPath(ConvertDocumentToFormatExample.class, fileName);
			Path p1=Paths.get("/home/mateen/test182017.docx");

			// upload file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",p1.toFile());

			
			
			
			// invoke Aspose.Words Cloud SDK API to convert words document to
			// required format
			ResponseMessage apiResponse = wordsApi.GetDocumentWithFormat(fileName, format, storage, folder, outPath,"");

			if (apiResponse != null && apiResponse.getInputStream() != null) {
				// save api response to file
				InputStream responseStream = apiResponse.getInputStream();
				final Path destination = Paths.get("test182017.html");
				Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ConvertDocumentToFormatExample
	}
}
