package com.aspose.words.cloud.bookmarks;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.Bookmark;
import com.aspose.words.model.BookmarksResponse;

public class GettingAllBookmarksExample {

	public static void main(String[] args) {
		// ExStart: GettingAllBookmarksExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String storage = null;
			String folder = null;
			
			Path path=Utils.getPath(GettingAllBookmarksExample.class, fileName);
	

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",path.toFile());

			// invoke Aspose.Words Cloud SDK API to get all the bookmarks from a
			// word document
			BookmarksResponse apiResponse = wordsApi.GetDocumentBookmarks(fileName, storage, folder);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				// display the bookmarks info
				for (Bookmark bookmark : apiResponse.getBookmarks().getBookmarkList()) {
					System.out.println("Name: " + bookmark.getName() + " Text: " + bookmark.getText() + " link: "
							+ bookmark.getLink().getHref());
				}
			}
            
		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: GettingAllBookmarksExample

	}

}
