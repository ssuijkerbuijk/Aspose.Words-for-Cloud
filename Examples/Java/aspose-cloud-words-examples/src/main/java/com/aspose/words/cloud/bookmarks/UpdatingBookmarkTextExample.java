package com.aspose.words.cloud.bookmarks;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.BookmarkData;
import com.aspose.words.model.BookmarkResponse;

public class UpdatingBookmarkTextExample {

	public static void main(String[] args) {
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
			
			Path path=Utils.getPath(UpdatingBookmarkTextExample.class, fileName);

			String storage = null;
			String folder = null;

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",path.toFile());

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
