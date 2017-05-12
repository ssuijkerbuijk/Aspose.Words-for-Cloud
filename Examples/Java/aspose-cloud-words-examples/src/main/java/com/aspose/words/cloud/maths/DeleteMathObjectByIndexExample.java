package com.aspose.words.cloud.maths;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.SaaSposeResponse;

public class DeleteMathObjectByIndexExample {

	public static void main(String[] args) {
		// ExStart: 1
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "MathsObject.docx";
			String storage = null;
			String folder = null;
			
			Path path=Utils.getPath(DeleteMathObjectByIndexExample.class, fileName);

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",path.toFile());

			// invoke Aspose.Words Cloud SDK API
			SaaSposeResponse apiResponse = wordsApi.DeleteOfficeMathObjects("MathsObject.docx", 1, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Office Math Object Delted from Document");
			}
            
		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: 1

	}

}
