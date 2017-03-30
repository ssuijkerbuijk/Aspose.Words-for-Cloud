//
//  Fields.h
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPWordsApi;

@interface Fields : NSObject

@property(nonatomic, strong) ASPWordsApi *wordsApi;

- (void)deleteDocumentFields;
- (void)deleteFormField;
- (void)deleteSectionFields;
- (void)getFormField;
- (void)postFormField;
- (void)postInsertPageNumbers;
- (void)postUpdateDocumentFields;
- (void)putFormField;
- (void)getDocumentFieldNames;

@end
