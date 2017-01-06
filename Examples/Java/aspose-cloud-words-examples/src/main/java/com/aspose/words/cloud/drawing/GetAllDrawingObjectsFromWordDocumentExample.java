package com.aspose.words.cloud.drawing;

import java.io.File;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;
import java.util.List;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DrawingObjectsResponse;
import com.aspose.words.model.LinkElement;
import com.aspose.words.model.ResponseMessage;

public class GetAllDrawingObjectsFromWordDocumentExample {

	public static void main(String[] args) {
		try{
            //Instantiate Aspose Storage API SDK
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID,true);

            //Instantiate Aspose Words API SDK
            WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID,true);

            //set input file name
            String fileName = "SampleWordDocument.docx";

            String storage = null;
            String folder = null;

            //upload input file to aspose cloud storage
            storageApi.PutCreate(fileName, "", "", new File(GetAllDrawingObjectsFromWordDocumentExample.class.getResource("/" + fileName).toURI()));

            //invoke Aspose.Words Cloud SDK API to get list of all drawing objects present in a word document
            DrawingObjectsResponse apiResponse = wordsApi.GetDocumentDrawingObjects(fileName, storage, folder);

            if(apiResponse!=null && apiResponse.getStatus().equals("OK")){
                    List<LinkElement> linkElements = apiResponse.getDrawingObjects().getList();

                    //export all drawing objects to PNG
                    for(int objectIndex=0; objectIndex < linkElements.size() ; objectIndex++){

                            ResponseMessage pngImageDataRes = wordsApi.GetDocumentDrawingObjectByIndexWithFormat(fileName, objectIndex, "png", storage, folder);

                            if(pngImageDataRes!=null && pngImageDataRes.getStatus().equals("OK")
                                            && pngImageDataRes.getInputStream()!=null){

                                    String destFileName = "DrawingObject_" + objectIndex + ".png";

                                    // save the image data
                                    final Path destination = Paths.get(destFileName);
                                    Files.copy(pngImageDataRes.getInputStream(),destination,StandardCopyOption.REPLACE_EXISTING);
                            }


                    }
            }

    }catch(Exception e){
            e.printStackTrace();
            }


	}

}
