package com.aspose.words.cloud.watermarks;

import java.io.File;


import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentResponse;

public class AddWaterMarkToDocumentExample {

	public static void execute(Context context) throws Exception {
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
			String storage = "AsposeDropboxStorage";
			String folder = null;
			//String image = "background.png";
			File file;

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));
			File image = Utils.stream2file("background",".png", context.getResources().openRawResource(R.raw.asposelogo));


			// upload input file to 3rd party cloud storage
			storageApi.PutCreate(fileName, "", storage, input);

			// upload input file to 3rd party cloud storage
			storageApi.PutCreate("background.png", "", storage, image);

			// invoke Aspose.Words Cloud SDK API to add watermark image in a
			// word document
			DocumentResponse apiResponse = wordsApi.PostInsertWatermarkImage(fileName, destFileName, rotationAngle,
					"background.png", storage, folder, image);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("Watermark image has been added successfully");



			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: AddWaterMarkToDocumentExample
	}
}
