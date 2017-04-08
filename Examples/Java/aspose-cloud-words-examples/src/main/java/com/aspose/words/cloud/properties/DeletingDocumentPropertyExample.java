package com.aspose.words.cloud.properties;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.SaaSposeResponse;

public class DeletingDocumentPropertyExample {

	public static void main(String[] args) {
		// ExStart: DeletingDocumentPropertyExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String propertyName = "AsposeAuthor";
			String storage = null;
			String folder = null;
			
            Path p1=Utils.getPath(DeletingDocumentPropertyExample.class, fileName);


			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					p1.toFile());

			// invoke Aspose.Words Cloud SDK API to delete document property by
			// given name from a word document
			SaaSposeResponse apiResponse = wordsApi.DeleteDocumentProperty(fileName, propertyName, fileName, storage,
					folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("The document property has been removed successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: DeletingDocumentPropertyExample

	}

}
