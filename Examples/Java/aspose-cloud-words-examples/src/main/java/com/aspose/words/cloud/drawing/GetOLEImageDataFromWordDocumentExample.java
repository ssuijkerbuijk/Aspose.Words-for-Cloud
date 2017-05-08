package com.aspose.words.cloud.drawing;

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.cloud.convert.AppendDocumentExample;
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

			Path p1=Utils.getPath(AppendDocumentExample.class, fileName);
			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",p1.toFile());

			// invoke Aspose.Words Cloud SDK API to get ole
			// drawing object by index in a word document
			ResponseMessage apiResponse = wordsApi.GetDocumentDrawingObjectOleData(fileName, objectIndex, storage,
					folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK") && apiResponse.getInputStream() != null) {

				String destFileName = "OLEDrawingObject_" + objectIndex + ".pdf";

				// save the ole data
				final Path destination = Paths.get("./" + destFileName);

				Files.copy(apiResponse.getInputStream(), destination, StandardCopyOption.REPLACE_EXISTING);

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		//ExEnd: GetOLEImageDataFromWordDocumentExample

	}

}
