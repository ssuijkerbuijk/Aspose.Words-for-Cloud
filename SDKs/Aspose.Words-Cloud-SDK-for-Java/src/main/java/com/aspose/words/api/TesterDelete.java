package com.aspose.words.api;

import com.aspose.words.model.FootnotesDTO;
import com.aspose.words.model.FootnotesResponse;
import com.aspose.words.model.Position;

public class TesterDelete {

	public static void main(String[] args) {
		String APP_SID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
		String API_KEY = "b125f13bf6b76ed81ee990142d841195";
		WordsApi wordsApi = new WordsApi("http://api.aspose.cloud/v1.1/", API_KEY, APP_SID);
		
		FootnotesDTO fd=new FootnotesDTO();
		Position p=new Position();
		p.setOffset(10);
	
				
		fd.setPosition(p);
		fd.setText("Hello");
		fd.setFootnoteType("fd");
		fd.setReferenceMark("34");
		
		FootnotesResponse cr=wordsApi.PostFootnotes("NewDocument.docx",1,0,1,null,null,fd);
		
		
		System.out.println(cr.getCode());
		
		
		

	}

}
