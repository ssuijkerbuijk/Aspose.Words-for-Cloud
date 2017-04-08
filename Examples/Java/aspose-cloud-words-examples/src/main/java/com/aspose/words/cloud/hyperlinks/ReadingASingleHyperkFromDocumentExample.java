package com.aspose.words.cloud.hyperlinks;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.cloud.convert.AppendDocumentExample;
import com.aspose.words.model.Hyperlink;
import com.aspose.words.model.HyperlinkResponse;

public class ReadingASingleHyperkFromDocumentExample {

	public static void main(String[] argv) {
		// ExStart: ReadingASingleHyperkFromDocumentExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			Integer hyperlinkIndex = 0;
			String storage = null;
			String folder = null;

			Path p1=Utils.getPath(AppendDocumentExample.class, fileName);
			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
					p1.toFile());

			// invoke Aspose.Words Cloud SDK API to get a particular hyperlink
			// in a word document
			HyperlinkResponse apiResponse = wordsApi.GetDocumentHyperlinkByIndex(fileName, hyperlinkIndex, storage,
					folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				Hyperlink hyperlink = apiResponse.getHyperlink();

				if (hyperlink != null) {
					// display the hyperlink info
					System.out.println("Display Text: " + hyperlink.getDisplayText() + " Value: " + hyperlink.getValue()
							+ " link: " + hyperlink.getLink().getHref());
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ReadingASingleHyperkFromDocumentExample

	}

}
