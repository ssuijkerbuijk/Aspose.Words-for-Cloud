//
//  DocumentProperties.h
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 16/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPWordsApi;

@interface DocumentProperties : NSObject

@property(nonatomic, strong) ASPWordsApi *wordsApi;

- (void)deleteDocumentProperty;
- (void)getDocumentProperties;
- (void)getDocumentProperty;
- (void)putUpdateDocumentProperty;

@end
