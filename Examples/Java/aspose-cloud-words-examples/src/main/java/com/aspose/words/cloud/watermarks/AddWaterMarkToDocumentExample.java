package com.aspose.words.cloud.watermarks;

import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.DocumentResponse;

public class AddWaterMarkToDocumentExample {

	public static void main(String[] args) {
		// ExStart: AddWaterMarkToDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleBlankWordDocument.docx";
			String destFileName = "updated-" + fileName;
			Double rotationAngle = 0.0;
			String storage = null;
			String folder = null;
			String image = "background.png";

            Path p1=Utils.getPath(AddWaterMarkToDocumentExample.class, fileName);
            Path p2=Utils.getPath(AddWaterMarkToDocumentExample.class, fileName);
			
			// upload input file to 3rd party cloud storage
			storageApi.PutCreate(fileName, "", storage,
					p1.toFile());

			
			// upload input file to 3rd party cloud storage
			storageApi.PutCreate(image, "", storage,
					p2.toFile());

		
			// invoke Aspose.Words Cloud SDK API to add watermark image in a
			// word document
			DocumentResponse apiResponse = wordsApi.PostInsertWatermarkImage(fileName, destFileName, rotationAngle,
					image, storage, folder, p2.toFile());

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Watermark image has been added successfully");

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
		// ExEnd: AddWaterMarkToDocumentExample
	}
}
