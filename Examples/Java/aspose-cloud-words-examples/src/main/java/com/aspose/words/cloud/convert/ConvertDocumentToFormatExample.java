package com.aspose.words.cloud.convert;

import java.io.File;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.ResponseMessage;
import com.aspose.words.model.SaveOptions;

public class ConvertDocumentToFormatExample {

	public static void main(String... argc) {
		// ExStart: ConvertDocumentToFormatExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "test_doc.docx";

			// set the desire output format
			String format = "pdf";
			String storage = "";
			String folder = "";
			String outPath = "";

			// upload file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					new File(ConvertDocumentToFormatExample.class.getResource("/" + fileName).toURI()));

			
			
			
			// invoke Aspose.Words Cloud SDK API to convert words document to
			// required format
			ResponseMessage apiResponse = wordsApi.GetDocumentWithFormat(fileName, format, storage, folder, outPath);

			if (apiResponse != null && apiResponse.getInputStream() != null) {
				// save api response to file
				InputStream responseStream = apiResponse.getInputStream();
				final Path destination = Paths.get("WordFormatConverterExampleTest.pdf");
				Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ConvertDocumentToFormatExample
	}
}
