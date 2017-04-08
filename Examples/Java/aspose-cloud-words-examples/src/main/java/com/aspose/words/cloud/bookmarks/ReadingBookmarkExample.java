package com.aspose.words.cloud.bookmarks;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.cloud.config.Utils;
import com.aspose.words.model.BookmarkResponse;

public class ReadingBookmarkExample {

	public static void main(String[] args) {
		// ExStart: ReadingBookmarkExample
		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String bookmarkName = "_Toc76372689";
			String storage = null;
			String folder = null;
			
			Path path=Utils.getPath(ReadingBookmarkExample.class, fileName);

			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "",
			      path.toFile());

			// invoke Aspose.Words Cloud SDK API to get the bookmark by given
			// name from a word document
			BookmarkResponse apiResponse = wordsApi.GetDocumentBookmarkByName(fileName, bookmarkName, storage, folder);

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
		// ExEnd: ReadingBookmarkExample

	}

}
