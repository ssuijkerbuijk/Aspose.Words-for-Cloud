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

public class PutConvertExample {

	public static void main(String[] args) {
		// ExStart: 1
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// invoke Aspose.Words Cloud SDK API
			ResponseMessage apiResponse = wordsApi.PutConvertDocument("pdf", "",new File("/home/mateen/test2408.docx"));
			InputStream responseStream = apiResponse.getInputStream();
            final Path destination = Paths.get("/home/mateen/output123457777.pdf");
            Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);
            System.out.println("conversion completed");
	

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				System.out.println("OK");
			}

		} catch (Exception e) {
			e.printStackTrace();

		}
	}
}