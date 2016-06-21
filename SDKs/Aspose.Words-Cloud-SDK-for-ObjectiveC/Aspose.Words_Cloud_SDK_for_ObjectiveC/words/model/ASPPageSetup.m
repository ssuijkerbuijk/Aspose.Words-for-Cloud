#import "ASPPageSetup.h"

@implementation ASPPageSetup

/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper
{
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"Bidi": @"bidi", @"BorderAlwaysInFront": @"borderAlwaysInFront", @"BorderAppliesTo": @"borderAppliesTo", @"BorderDistanceFrom": @"borderDistanceFrom", @"BottomMargin": @"bottomMargin", @"DifferentFirstPageHeaderFooter": @"differentFirstPageHeaderFooter", @"FirstPageTray": @"firstPageTray", @"FooterDistance": @"footerDistance", @"Gutter": @"gutter", @"HeaderDistance": @"headerDistance", @"LeftMargin": @"leftMargin", @"LineNumberCountBy": @"lineNumberCountBy", @"LineNumberDistanceFromText": @"lineNumberDistanceFromText", @"LineNumberRestartMode": @"lineNumberRestartMode", @"LineStartingNumber": @"lineStartingNumber", @"Orientation": @"orientation", @"OtherPagesTray": @"otherPagesTray", @"PageHeight": @"pageHeight", @"PageNumberStyle": @"pageNumberStyle", @"PageStartingNumber": @"pageStartingNumber", @"PageWidth": @"pageWidth", @"PaperSize": @"paperSize", @"RestartPageNumbering": @"restartPageNumbering", @"RightMargin": @"rightMargin", @"RtlGutter": @"rtlGutter", @"SectionStart": @"sectionStart", @"SuppressEndnotes": @"suppressEndnotes", @"TopMargin": @"topMargin", @"VerticalAlignment": @"verticalAlignment", @"link": @"link" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName
{
  NSArray *optionalProperties = @[@"bidi", @"borderAlwaysInFront", @"borderAppliesTo", @"borderDistanceFrom", @"bottomMargin", @"differentFirstPageHeaderFooter", @"firstPageTray", @"footerDistance", @"gutter", @"headerDistance", @"leftMargin", @"lineNumberCountBy", @"lineNumberDistanceFromText", @"lineNumberRestartMode", @"lineStartingNumber", @"orientation", @"otherPagesTray", @"pageHeight", @"pageNumberStyle", @"pageStartingNumber", @"pageWidth", @"paperSize", @"restartPageNumbering", @"rightMargin", @"rtlGutter", @"sectionStart", @"suppressEndnotes", @"topMargin", @"verticalAlignment", @"link"];

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
