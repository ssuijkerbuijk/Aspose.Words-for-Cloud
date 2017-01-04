package com.aspose.words.cloud.fields;

import java.io.File;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentResponse;

public class UpdatingAllFieldsDocumentExample {

	public static void main(String[] args) {
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";

			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", storage,
					new File(UpdatingAllFieldsDocumentExample.class.getResource("/" + fileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to update fields in the whole
			// document
			DocumentResponse apiResponse = wordsApi.PostUpdateDocumentFields(fileName, fileName, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				System.out.println("Document fields have been updated successfully");
			}

		} catch (Exception e) {
			e.printStackTrace();
		}

	}

}
