# Tesseract_Execute

This program is for use with ARIA/Eclipse, which is a commerical radiation treatment planning software suite made by Varian Medical Systems which is used in Radiation Oncology. This is one of several programs which I have made while working in the Radiation Oncology department at Lahey Hospital and Medical Center in Burlington, MA. I have licensed it under GPL V3 so it is open-source and publicly available.

There is also a .docx README file in the repo that describes what the program does and how it is organized.

Tesseract Execute is a very small console program that uses the open-source Tesseract OCR (optical character recognition) library to read text from images.

Tesseract Execute is used to make simple text files from the scanned patient documents that are added to ARIA so that they can be used by the document check module of the Plancheck program (separate repo).

This is neccesary because the scanned documents are saved as PDFs that simply contain an image of the scanned document. This works for record keeping purposes for the clinic, but in order to extract useful information from these documents so they can be used as part of a comprehensive plancheck program, an OCR, like Tesseract, is needed.

Tesseract Execute is meant to be compiled into an executable file so it can be called as needed by the PatientScansOCRBackgroundWorker windows service which monitors the ARIA documents folder.

Please note that the Tesseract library used here is a C# wrapper for a C++ library, so the .NET C++ runtime is required to run it.

Please refer to the .docx README file for additional information about this program, including additional technical information about Tesseract.