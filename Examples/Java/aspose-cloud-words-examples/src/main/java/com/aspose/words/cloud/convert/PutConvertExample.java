package com.aspose.words.cloud.convert;

import java.io.File;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.ResponseMessage;

public class PutConvertExample {

	public static void main(String[] args) {
		// ExStart: 1
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// invoke Aspose.Words Cloud SDK API
			ResponseMessage apiResponse = wordsApi.PutConvertDocument("pdf", "",
					new File("/home/mateen/sample.doc"));
	

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				System.out.println("OK");
			}

		} catch (Exception e) {
			e.printStackTrace();

		}
	}
}