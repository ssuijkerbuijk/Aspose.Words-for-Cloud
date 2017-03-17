//
//  Paragraphs.h
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPWordsApi;

@interface Paragraphs : NSObject

@property(nonatomic, strong) ASPWordsApi *wordsApi;

- (void)deleteParagraphFields;
- (void)getDocumentParagraph;
- (void)getDocumentParagraphRun;
- (void)getDocumentParagraphRunFont;
- (void)getDocumentParagraphs;
- (void)postDocumentParagraphRunFont;

@end
