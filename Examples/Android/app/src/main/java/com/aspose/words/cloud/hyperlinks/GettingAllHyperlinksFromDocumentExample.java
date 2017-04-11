package com.aspose.words.cloud.hyperlinks;

import java.io.File;
import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.Hyperlink;
import com.aspose.words.model.HyperlinksResponse;

public class GettingAllHyperlinksFromDocumentExample {

	public static void execute(Context context) throws Exception{
		// ExStart: GettingAllHyperlinksFromDocumentExample
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
			storageApi.PutCreate(fileName, "", "",
					input);

			// invoke Aspose.Words Cloud SDK API to get all the hyperlinks in a
			// word document
			HyperlinksResponse apiResponse = wordsApi.GetDocumentHyperlinks(fileName, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				// get all the hyperlinks
				for (Hyperlink hyperlink : apiResponse.getHyperlinks().getHyperlinkList()) {
					System.out.println("Display Text: " + hyperlink.getDisplayText() + " Value: " + hyperlink.getValue()
							+ " link: " + hyperlink.getLink().getHref());
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: GettingAllHyperlinksFromDocumentExample

	}

}
