using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace KingKeeper.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="ZipArchive"/> and <see cref="ZipArchiveEntry"/> classes.
    /// </summary>
    static class ZipFileExtensions
    {
        /// <summary>
        /// Extracts an entry in the zip archive to an array of bytes.
        /// </summary>
        /// <param name="source">The zip archive entry to extract from.</param>
        /// <returns>An array of bytes containing the contents of the entry.</returns>
        public static byte[] Extract(this ZipArchiveEntry source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            
            using (var dst = new MemoryStream())
            {
                using (var src = source.Open())
                {
                    src.CopyTo(dst);
                }

                return dst.ToArray();
            }
        }

        /// <summary>
        /// Extracts an entry in the zip archive to a string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ExtractToString(this ZipArchiveEntry source)
        {
            return ExtractToString(source, null);
        }

        /// <summary>
        /// Extracts an entry in the zip archive to a string.
        /// </summary>
        /// <param name="source">The zip archive entry to extract a string from.</param>
        /// <param name="encoding"></param>
        /// <returns>A string containing the contents of the entry.</returns>
        public static string ExtractToString(this ZipArchiveEntry source, Encoding encoding)
        {
            if (encoding == null)
                encoding = Encoding.UTF8;

            return encoding.GetString(Extract(source));
        }

        /// <summary>
        /// Extracts an entry in the zip archive to an image.
        /// </summary>
        /// <param name="source">The zip archive entry to extract an image from.</param>
        /// <returns></returns>
        public static Image ExtractToImage(this ZipArchiveEntry source)
        {
            using (var stream = new MemoryStream(Extract(source)))
                return new Bitmap(stream);
        }

        /// <summary>
        /// Extracts an entry in the zip archive to an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The zip archive entry to extract an object from.</param>
        /// <returns>The object as deserialized from the entry.</returns>
        public static T ExtractToObject<T>(this ZipArchiveEntry source)
        {
            return JsonConvert.DeserializeObject<T>(ExtractToString(source), new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
        }

        /// <summary>
        /// Replaces an entry by compressing a string and adding it to the zip archive.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="str"></param>
        /// <param name="entryName"></param>
        /// <returns></returns>
        public static ZipArchiveEntry ReplaceEntryFromString(this ZipArchive source, string str,
            Encoding encoding, string entryName)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));

            if (encoding == null)
                encoding = Encoding.UTF8;

            return ReplaceEntry(source, encoding.GetBytes(str), entryName);
        }

        /// <summary>
        /// Replaces an entry by compressing a string and adding it to the zip archive.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="str"></param>
        /// <param name="entryName"></param>
        /// <returns></returns>
        public static ZipArchiveEntry ReplaceEntryFromString(this ZipArchive source, string str, string entryName)
        {
            return ReplaceEntryFromString(source, str, null, entryName);
        }

        /// <summary>
        /// Replaces an entry by compression an array of bytes and adding it to the zip archive.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="bytes"></param>
        /// <param name="entryName"></param>
        /// <returns></returns>
        public static ZipArchiveEntry ReplaceEntry(this ZipArchive source, byte[] bytes, string entryName)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            using (var stream = new MemoryStream(bytes))
            {
                return ReplaceEntry(source, stream, entryName);
            }
        }

        /// <summary>
        /// Replaces an entry by compressing a stream and adding it to the zip archive.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="stream"></param>
        /// <param name="entryName"></param>
        /// <returns></returns>
        public static ZipArchiveEntry ReplaceEntry(this ZipArchive source, Stream stream, string entryName)
        {
            // Remove the old entry
            var old = source.GetEntry(entryName);
            if (old != null)
                old.Delete();

            // Create the replacement entry
            var entry = source.CreateEntry(entryName);
            entry.LastWriteTime = DateTime.Now; // ???: Is this really necessary?

            using (var dst = entry.Open())
            {
                stream.CopyTo(dst);
            }

            return entry;
        }
    }
}
