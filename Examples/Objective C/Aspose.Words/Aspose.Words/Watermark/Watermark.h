//
//  Watermark.h
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPWordsApi;

@interface Watermark : NSObject

@property(nonatomic, strong) ASPWordsApi *wordsApi;

- (void)deleteDocumentWatermark;
- (void)postInsertDocumentWatermarkImage;
- (void)postInsertDocumentWatermarkText;

@end
