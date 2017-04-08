package com.aspose.words.cloud.paragraphs;

import java.io.File;
import java.io.InputStream;





import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.Font;
import com.aspose.words.model.FontResponse;

public class UpdatingFontForRunParagraphExample {

	public static void execute(Context context) throws Exception {
		// ExStart: UpdatingFontForRunParagraphExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String destFileName = "updated-" + fileName;
			Integer index = 0;
			Integer runIndex = 0;
			String storage = null;
			String folder = null;

			Font body = new Font();
			body.setBold(true);
			body.setSize(31.0);
			body.setName("Calibri");

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.SampleWordDocument));


			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					input);

			// invoke Aspose.Words Cloud SDK API to update font of a specific
			// run of a paragraph present in a word document
			FontResponse apiResponse = wordsApi.PostDocumentParagraphRunFont(fileName, index, runIndex, storage, folder,
					destFileName, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				System.out.println("paragraph run font has been updated successfully");

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: UpdatingFontForRunParagraphExample

	}

}
