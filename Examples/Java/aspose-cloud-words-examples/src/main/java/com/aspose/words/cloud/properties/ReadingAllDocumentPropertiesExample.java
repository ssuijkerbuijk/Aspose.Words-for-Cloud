package com.aspose.words.cloud.properties;

import java.io.File;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentPropertiesResponse;
import com.aspose.words.model.DocumentProperty;

public class ReadingAllDocumentPropertiesExample {
	public static void main(String[] argv) {
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
			storageApi.PutCreate(fileName, "", "",
					new File(ReadingAllDocumentPropertiesExample.class.getResource("/" + fileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to get all document properties
			// from a word document
			DocumentPropertiesResponse apiResponse = wordsApi.GetDocumentProperties(fileName, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				// display document property info
				for (DocumentProperty docProperty : apiResponse.getDocumentProperties().getList()) {
					System.out.println(docProperty.getName() + "  :  " + docProperty.getValue());
				}

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
