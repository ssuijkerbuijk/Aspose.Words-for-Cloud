package com.aspose.words.cloud.drawing;

import java.io.File;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.ResponseMessage;

public class GetOLEImageDataFromWordDocumentExample {

	public static void main(String[] args) {
		//ExStart: GetOLEImageDataFromWordDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleOlePdfData.docx";
			Integer objectIndex = 0;

			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					new File(GetOLEImageDataFromWordDocumentExample.class.getResource("/" + fileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to get ole
			// drawing object by index in a word document
			ResponseMessage apiResponse = wordsApi.GetDocumentDrawingObjectOleData(fileName, objectIndex, storage,
					folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK") && apiResponse.getInputStream() != null) {

				String destFileName = "OLEDrawingObject_" + objectIndex + ".pdf";

				// save the ole data
				final Path destination = Paths.get("c:\\temp\\" + destFileName);

				Files.copy(apiResponse.getInputStream(), destination, StandardCopyOption.REPLACE_EXISTING);

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		//ExEnd: GetOLEImageDataFromWordDocumentExample

	}

}
