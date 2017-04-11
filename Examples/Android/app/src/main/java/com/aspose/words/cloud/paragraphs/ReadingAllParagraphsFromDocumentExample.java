package com.aspose.words.cloud.paragraphs;

import java.io.File;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.ParagraphLink;
import com.aspose.words.model.ParagraphLinkCollectionResponse;

public class ReadingAllParagraphsFromDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: ReadingAllParagraphsFromDocumentExample

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

			// invoke Aspose.Words Cloud SDK API to get list of paragraphs from
			// a word document
			ParagraphLinkCollectionResponse apiResponse = wordsApi.GetDocumentParagraphs(fileName, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				ParagraphLink docProperty = apiResponse.getParagraphs().getParagraphLinkList().get(0);

				// display document paragraphs info
				for (ParagraphLink docParagraphLink : apiResponse.getParagraphs().getParagraphLinkList()) {
					System.out.println("Link : " + docParagraphLink.getLink());
					System.out.println("Text : " + docParagraphLink.getText());
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ReadingAllParagraphsFromDocumentExample

	}

}
