package com.aspose.words.cloud.bookmarks;

import java.io.File;

import java.io.File; import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.BookmarkData;
import com.aspose.words.model.BookmarkResponse;

public class UpdatingBookmarkTextExample {

	public static void execute(Context context) throws Exception {
		// ExStart: UpdatingBookmarkTextExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String bookmarkName = "aspose";
			String destFileName = null;

			BookmarkData body = new BookmarkData();
			body.setName("aspose");
			body.setText("This is updated Bookmark");

			String storage = null;
			String folder = null;

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",input);

			// invoke Aspose.Words Cloud SDK API to update the bookmark from a
			// word document
			BookmarkResponse apiResponse = wordsApi.PostUpdateDocumentBookmark(fileName, bookmarkName, destFileName,
					storage, folder, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				if (apiResponse.getBookmark() != null) {
					// display bookmark info
					System.out.println("Name: " + apiResponse.getBookmark().getName() + " Text: "
							+ apiResponse.getBookmark().getText() + " link: "
							+ apiResponse.getBookmark().getLink().getHref());
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}

		// ExEnd: UpdatingBookmarkTextExample
	}
}
