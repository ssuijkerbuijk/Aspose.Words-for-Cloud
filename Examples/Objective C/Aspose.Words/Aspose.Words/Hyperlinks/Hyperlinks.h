//
//  Hyperlinks.h
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPWordsApi;

@interface Hyperlinks : NSObject

@property(nonatomic, strong) ASPWordsApi *wordsApi;

- (void)getDocumentHyperlinkByIndex;
- (void)getDocumentHyperlinks;

@end
