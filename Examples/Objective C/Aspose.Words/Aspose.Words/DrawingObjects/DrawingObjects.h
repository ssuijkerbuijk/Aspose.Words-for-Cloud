//
//  DrawingObjects.h
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 16/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPWordsApi;

@interface DrawingObjects : NSObject

@property(nonatomic, strong) ASPWordsApi *wordsApi;

- (void)getDocumentDrawingObjectByIndex;
- (void)getDocumentDrawingObjectByIndexWithFormat;
- (void)getDocumentDrawingObjectImageData;
- (void)getDocumentDrawingObjectOleData;
- (void)getDocumentDrawingObjects;

@end
