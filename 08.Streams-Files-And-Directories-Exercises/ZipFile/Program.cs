using System.IO.Compression;

string zipPath = @"../../../test.zip";
string extractPath = @"../../../Extracted";
string newFile = @"c:\users\exampleuser\NewFile.txt";

using (ZipArchive zip = ZipFile.Open(zipPath, ZipArchiveMode.Update))
{
    zip.CreateEntryFromFile("../../../copyMe.png", "copyMe.png");
    zip.ExtractToDirectory(extractPath);
}