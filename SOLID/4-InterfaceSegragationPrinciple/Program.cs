using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_InterfaceSegragationPrinciple
{
    class Program
    {
        /// <summary>
        /// This program violates ISP
        ///  A client should not be forced to depend on an interface they dont use - book below works - everything else fails ISP
        ///  
        /// Book - implements the ILibraryItem - and evertyhign in ILibraryItem is right to apply to the book 
        /// AudioBook - implements ILibraryItem interface - an Audiobook doesnt have pages though - so we set to -1 so it doesnt reflect actual value - other things need chaging as well
        /// ReferenceBook - implements ILibraryItem - cant checkout so set CheckoutDuration to 0 - Checkout, Checkin, GetDureDate to throw and exceptions - other things need chaging as well
        /// DVD - implements ILibraryItem - doesnt have pages or an Author - we want to add Actors and RunTimeInMinutes - other things need chaging as well
        /// 
        /// Make sure ILibraryItem has only fields that are universal across all classes that implement it.
        /// So ILibraryItem is left with LibraryID and Title only 
        /// 
        /// Create IBook and add Author and Pages fields that where in ILibrarItem but shouldnbt have been applied to all classes e.g. Audiobook 
        /// Create IBorrowable - put in all the Borrowable fields - this doesnt implements the ILibraryItem
        /// Create IBorrowableBook - implements IBook and IBorrowable
        /// 
        /// Reference Book can implement IBook - remove all checkout fields as these books cant be checked out
        /// 
        /// AudioBook - is not a book - some are borrowable and some arent 
        /// Create IAudioBook- has runtime field - implements ILibraryItem interface for LibraryID and Title
        /// Create IBorowableAudioBook - implements IAudioBook, IBorrowable
        /// AudioBook Implements IBorrowableAudioBook
        /// 
        /// DVD - get rid of Author and Pages fields
        /// Create IDVD - implements ILibraryItem - has runtime and actors fields
        /// Create IBorrawableDVD - implements IDVD and IBorrowable
        /// DVD implemnents IBorrowableDVD
        /// 
        /// Creating the IBorroabel empty interfaces allows us to refernce the IBorrowable interfaces without any casting issues,
        /// see  IBorrowableDVD dvd = new DVD(); in program - dvd has access to all the fields of a BorrowableDVD
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args)
        {

            Console.ReadLine();

        }
    }
}
