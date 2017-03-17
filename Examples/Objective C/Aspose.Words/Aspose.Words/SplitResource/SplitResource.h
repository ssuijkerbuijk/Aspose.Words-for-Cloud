//
//  SplitResource.h
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPWordsApi;

@interface SplitResource : NSObject

@property(nonatomic, strong) ASPWordsApi *wordsApi;

- (void)splitAllPagesToNewPdfs;
- (void)splitSpecificPagesToAnySupportedFormat;
- (void)splitSpecificPagesToNewPdfs;

@end
