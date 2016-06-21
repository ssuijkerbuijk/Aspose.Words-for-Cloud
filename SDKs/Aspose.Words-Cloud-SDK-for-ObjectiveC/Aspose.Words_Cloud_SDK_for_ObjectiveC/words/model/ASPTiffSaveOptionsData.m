#import "ASPTiffSaveOptionsData.h"

@implementation ASPTiffSaveOptionsData

/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper
{
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"TiffBinarizationMethod": @"tiffBinarizationMethod", @"TiffCompression": @"tiffCompression", @"PageCount": @"pageCount", @"PixelFormat": @"pixelFormat", @"PaperColor": @"paperColor", @"Resolution": @"resolution", @"Scale": @"scale", @"ImageBrightness": @"imageBrightness", @"ImageColorMode": @"imageColorMode", @"ImageContrast": @"imageContrast", @"UseHighQualityRendering": @"useHighQualityRendering", @"UseAntiAliasing": @"useAntiAliasing", @"PageIndex": @"pageIndex", @"MetafileRenderingOptions": @"metafileRenderingOptions", @"NumeralFormat": @"numeralFormat", @"SaveFormat": @"saveFormat", @"FileName": @"fileName", @"DmlRenderingMode": @"dmlRenderingMode", @"DmlEffectsRenderingMode": @"dmlEffectsRenderingMode", @"ZipOutput": @"zipOutput" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName
{
  NSArray *optionalProperties = @[@"tiffBinarizationMethod", @"tiffCompression", @"pageCount", @"pixelFormat", @"paperColor", @"resolution", @"scale", @"imageBrightness", @"imageColorMode", @"imageContrast", @"useHighQualityRendering", @"useAntiAliasing", @"pageIndex", @"metafileRenderingOptions", @"numeralFormat", @"saveFormat", @"fileName", @"dmlRenderingMode", @"dmlEffectsRenderingMode", @"zipOutput"];

  if ([optionalProperties containsObject:propertyName]) {
    return YES;
  }
  else {
    return NO;
  }
}

/**
 * Gets the string presentation of the object.
 * This method will be called when logging model object using `NSLog`.
 */
- (NSString *)description {
    return [[self toDictionary] description];
}

@end
