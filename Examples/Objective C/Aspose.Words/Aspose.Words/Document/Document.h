//
//  Document.h
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 16/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPWordsApi;

@interface Document : NSObject

@property(nonatomic, strong) ASPWordsApi *wordsApi;

- (void)testAcceptAllRevisions;
- (void)deleteDocumentMacros;
- (void)getDocument;
- (void)getDocumentStatistics;
- (void)getDocumentWithFormat;
- (void)postAppendDocument;
- (void)postDocumentSaveAs;
- (void)postLoadWebDocument;
- (void)postRunTask;
- (void)putConvertDocument;
- (void)putDocumentSaveAsTiff;
- (void)testRejectAllRevisions;

@end
