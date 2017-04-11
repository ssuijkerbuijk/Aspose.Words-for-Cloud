package com.aspose.words.cloud.drawing;

import java.io.File;
import java.io.File;
import com.aspose.storage.api.StorageApi;
import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DrawingObject;
import com.aspose.words.model.DrawingObjectResponse;

public class GetImageDataFromWordDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: GetImageDataFromWordDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			Integer objectIndex = 0;

			String storage = null;
			String folder = null;
			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to get drawing object by index
			// present in a word document
			DrawingObjectResponse apiResponse = wordsApi.GetDocumentDrawingObjectByIndex(fileName, objectIndex, storage,
					folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				DrawingObject drawingObject = apiResponse.getDrawingObject();
				// display basic drawingObject info
				System.out.println("Height: " + drawingObject.getHeight());
				System.out.println("Width: " + drawingObject.getWidth());
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: GetImageDataFromWordDocumentExample

	}

}
