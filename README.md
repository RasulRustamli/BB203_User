IAccount (interface):
- PasswordChecker() - parametr olaraq string password qəbul edir.
- ShowInfo()

User class (IAccount-u implement edir)
- Id
- Fullname
- Email
- Password
- PasswordChecker() - PasswordChecker methodu - gələn string password dəyərinin şərtləri ödəyib ödəmədiyini yoxlayıb true/false dəyər qaytarir.                        Şərtlər:
                        - şifrədə minimum 8 character olmalıdır
                        - şifrədə ən az 1 böyük hərf olmalıdır
                        - şifrədə ən az 1 kiçik hərf olmalıdır
                        - şifrədə ən az 1 rəqəm olmalıdır
- ShowInfo() - bu method console-a user-in Id, Fullname və email dəyərlərini yazdırır


ps: Id dəyəri hər dəfə bir user obyekti yaranan zaman avtomatik artmalıdır və qıraqdan id dəyərini dəyişmək olmamalıdı ancaq get etmək olar. User yarandığı zaman email və password təyin edilməsi məcburidir.User-ə şifrə təyin edilərkən şifrənin PasswordChecker methodunun şərtlərini ödəməsi lazımdır.
