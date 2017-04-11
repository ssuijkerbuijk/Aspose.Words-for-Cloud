package com.aspose.words.cloud.paragraphs;

import java.io.File;

import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.Paragraph;
import com.aspose.words.model.ParagraphResponse;

public class ReadingParticularParagraphFromDocumentExample {

	public static void execute(Context context) throws Exception {
		// ExStart: ReadingParticularParagraphFromDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			Integer index = 1;
			String storage = null;
			String folder = null;
			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to get a specific paragraph
			// from a word document
			ParagraphResponse apiResponse = wordsApi.GetDocumentParagraph(fileName, index, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				Paragraph docParagraph = apiResponse.getParagraph();
				// display document paragraph info
				if (docParagraph != null) {
					System.out.println("NoteId : " + docParagraph.getNodeId());
					System.out.println("Link : " + docParagraph.getLink().getHref());
				}

			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ReadingParticularParagraphFromDocumentExample

	}

}
