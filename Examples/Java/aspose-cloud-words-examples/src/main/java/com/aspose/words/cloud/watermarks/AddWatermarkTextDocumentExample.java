package com.aspose.words.cloud.watermarks;

import java.io.File;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentResponse;
import com.aspose.words.model.WatermarkText;

public class AddWatermarkTextDocumentExample {

	public static void main(String[] args) {
		// ExStart: AddWatermarkTextDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String destFileName = "updated-" + fileName;
			Double rotationAngle = 0.0;
			String storage = "AsposeDropboxStorage";
			String folder = null;
			String text = "New";
			WatermarkText body = new WatermarkText();
			body.setText("aspose.com");

			// upload input file to 3rd party cloud storage
			storageApi.PutCreate(fileName, "", storage,
					new File(AddWatermarkTextDocumentExample.class.getResource("/" + fileName).toURI()));

			// invoke Aspose.Words Cloud SDK API to add watermark text in a word
			// document
			DocumentResponse apiResponse = wordsApi.PostInsertWatermarkText(fileName, text, rotationAngle, destFileName,
					storage, folder, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Watermark text has been added successfully");

				// download updated file from 3rd party cloud storage
				com.aspose.storage.model.ResponseMessage storageRes = storageApi.GetDownload(destFileName, null,
						storage);

				InputStream responseStream = storageRes.getInputStream();

				final Path destination = Paths.get(destFileName);

				Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: AddWatermarkTextDocumentExample

	}

}
