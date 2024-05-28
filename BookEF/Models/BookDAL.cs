using BookEF.Data;

namespace BookEF.Models
{
    public class BookDAL
    {
        ApplicationDbContext db;
        public BookDAL(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Book> GetBooks()
        {
            var result = from b in db.Books
                         select b;
            return result;
        }
        public Book GetByBookId(int id)
        {
            /*var result = from b in db.Books
                         where b.id == id
                         select b;
            return (Book)result;*/
            var result = db.Books.Where(x => x.id== id).SingleOrDefault();
            return result;
        }
        public int AddBooks(Book books)
        {
           db.Books.Add(books);
           int result=  db.SaveChanges();
           return result;
        }
        public int UpadateBooks(Book book)
        {
            int res = 0;
            var result = db.Books.Where(x => x.id == book.id).FirstOrDefault();
            if(result != null)
            {
                result.name= book.name;
                result.author= book.author;
                result.price= book.price;
                res=db.SaveChanges();
            }
            return res;
        }
        public int DeleteBook(int id)
        {
            int res = 0;
            var result = db.Books.Where(x =>  x.id == id).FirstOrDefault(); 
            if(result != null)
            {
                db.Books.Remove(result); 
                db.SaveChanges();  
            }
            return res;
        }
    }
}
