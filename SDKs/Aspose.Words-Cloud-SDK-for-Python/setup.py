__author__ = 'farooq.sheikh'

from setuptools import setup, find_packages

setup(
    name = 'asposewordscloud',
    packages = find_packages(),
    version = '1.0.1',
    description = 'Aspose.Words Cloud SDK for Python allows you to use Aspose.Words APIs in your Python applications',
    author='Farooq Sheikh',
    author_email='farooq.sheikh@aspose.com',
    url='https://github.com/asposewords/Aspose_Words_Cloud/tree/master/SDKs/Aspose.Words_Cloud_SDK_for_Python',
    install_requires=[
        'asposestoragecloud',
    ],
    classifiers=[
        'Programming Language :: Python',
        'Programming Language :: Python :: 2',
        'License :: OSI Approved :: MIT License',
        'Operating System :: OS Independent'
    ]
)
