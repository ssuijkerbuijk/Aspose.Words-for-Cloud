package com.aspose.words.cloud.properties;

import java.io.File;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentProperty;
import com.aspose.words.model.DocumentPropertyResponse;

public class ReadingASinglePropertyFromDocumentExample {

	public static void main(String[] args) {
		// ExStart: ReadingASinglePropertyFromDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String propertyName = "Author";
			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					new File(ReadingASinglePropertyFromDocumentExample.class.getResource("/" + fileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to get document property by
			// given name from a word document
			DocumentPropertyResponse apiResponse = wordsApi.GetDocumentProperty(fileName, propertyName, storage,
					folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				DocumentProperty docProperty = apiResponse.getDocumentProperty();

				if (docProperty != null) {
					// display document property info
					System.out.println(docProperty.getName() + "  :  " + docProperty.getValue());
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ReadingASinglePropertyFromDocumentExample

	}

}
