package com.aspose.words.cloud.fields;

import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.cloud.convert.AppendDocumentExample;
import com.aspose.words.model.DocumentResponse;
import com.aspose.words.model.PageNumber;

public class AddPageNumberFieldDocumentExample {

	public static void main(String[] args) {
		// ExStart: AddPageNumberFieldDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";

			String storage = null;
			String folder = null;

			PageNumber body = new PageNumber();
			body.setFormat("{PAGE} of {NUMPAGES}");
			body.setAlignment("center");
			
			Path p1=Utils.getPath(AppendDocumentExample.class, fileName);

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					p1.toFile());

			// invoke Aspose.Words Cloud SDK API to insert page number field
			// into a word document
			DocumentResponse apiResponse = wordsApi.PostInsertPageNumbers(fileName, fileName, storage, folder, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				System.out.println("Page Number Field has been inserted successfully");
				// download updated file from cloud storage
				com.aspose.storage.model.ResponseMessage storageRes = storageApi.GetDownload(fileName, null, null);
				InputStream responseStream = storageRes.getInputStream();
				final Path destination = Paths.get("c:\\temp\\" + fileName);
				Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: AddPageNumberFieldDocumentExample

	}

}
