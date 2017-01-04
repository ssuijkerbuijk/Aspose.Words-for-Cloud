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
import com.aspose.words.model.Link;
import com.aspose.words.model.SplitDocumentResponse;

public class SplitDocumentExample {

	public static void main(String... argc) {
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String format = "pdf";
			Integer from = 2;
			Integer to = 3;
			Boolean zipOutput = false;
			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					new File(SplitDocumentExample.class.getResource("/" + fileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to split word document
			SplitDocumentResponse apiResponse = wordsApi.PostSplitDocument(fileName, format, from, to, zipOutput,
					storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				System.out.println("Document has been splitted to pfds successfully");

				// download splitted pdfs from storage server
				for (Link pageLink : apiResponse.getSplitResult().getPages()) {
					String outputFileName = pageLink.getHref();
					com.aspose.storage.model.ResponseMessage storageRes = storageApi.GetDownload(outputFileName, null,
							null);
					InputStream responseStream = storageRes.getInputStream();
					final Path destination = Paths.get("c:\\temp\\" + outputFileName);
					Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}

	}
}
