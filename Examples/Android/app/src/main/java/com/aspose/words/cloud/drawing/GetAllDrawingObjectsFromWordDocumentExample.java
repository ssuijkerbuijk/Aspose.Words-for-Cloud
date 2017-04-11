package com.aspose.words.cloud.drawing;

import java.io.File;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import java.util.List;
import java.io.File;
import com.aspose.storage.api.StorageApi;
import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DrawingObjectsResponse;
import com.aspose.words.model.LinkElement;
import com.aspose.words.model.ResponseMessage;

public class GetAllDrawingObjectsFromWordDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: GetAllDrawingObjectsFromWordDocumentExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";

			String storage = null;
			String folder = null;

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));


			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to get list of all drawing
			// objects present in a word document
			DrawingObjectsResponse apiResponse = wordsApi.GetDocumentDrawingObjects(fileName, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
				List<LinkElement> linkElements = apiResponse.getDrawingObjects().getList();

				// export all drawing objects to PNG
				for (int objectIndex = 0; objectIndex < linkElements.size(); objectIndex++) {

					ResponseMessage pngImageDataRes = wordsApi.GetDocumentDrawingObjectByIndexWithFormat(fileName,
							objectIndex, "png", storage, folder);

					if (pngImageDataRes != null && pngImageDataRes.getStatus().equals("OK")
							&& pngImageDataRes.getInputStream() != null) {

						String destFileName = "DrawingObject_" + objectIndex ;

						// save the image data

						File desination=Utils.createTempFile(destFileName, ".png");

						Utils.copyInputStreamToFile(pngImageDataRes.getInputStream(),desination);
					}

				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: GetAllDrawingObjectsFromWordDocumentExample

	}

}
