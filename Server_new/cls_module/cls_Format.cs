using System;
using System.Linq;

namespace Server
{
    class cls_Format
    {
        public cls_Format()
        {
        }
       
        public string NumberToVietnamese(double inputNumber)
        {
            /// Chuyển phần nguyên của số thành chữ
            /// 
            /// Số double cần chuyển thành chữ
            /// Chuỗi kết quả chuyển từ số
            /// Chuyển sang tiếng việt
            /// 
            string[] unitNumbers = new string[] { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string[] placeValues = new string[] { "", "Nghìn", "Triệu", "Tỷ" };
            string sNumber = "";

            // 12345678.3445435 => "12345678"
            if(inputNumber == 0)
                return unitNumbers[0];
            else 
                sNumber = inputNumber.ToString("#");

            int ones, tens, hundredss;
            int positionDigit = sNumber.Length;   // độ dài của chuỗi số đầu vào
            string result = " ";

            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0) 
                {
                    
                    // Kiểm tra 3 số cuối trong ### (hàng trăm, chục, đơn vị)
                    tens = hundredss = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundredss = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--; 
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundredss > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result; 

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1)) // ### = 1
                        result = "Mốt " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "Lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result; 
                    }
                    if (tens < 0) //nếu trong 3 chữ số đó chỉ có 1 số
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) // nếu 3 chữ số đó có hàng chục = 0
                            result = "Lẻ " + result;
                        if (tens == 1) // 10 -> 19
                            result = "Mười " + result;
                        if (tens > 1) // hàng chục lớn hơn 1 thêm mươi đằng sau
                            result = unitNumbers[tens] + " Mươi " + result;
                    }
                    if (hundredss < 0) break; // nếu trong 3 chữ số chỉ có 2 chữ số
                    else
                    {
                        if ((hundredss > 0) || (tens > 0) || (ones > 0)) 
                            result = unitNumbers[hundredss] + " Trăm " + result; // 3 chữ số thì chữ số đầu tiên là hàng trăm
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            return result;
        }

        //Chuyển sang tiếng Pháp
        //hàng đơn vị 0 -> 9
        public static string unites(string Number)
        {

            int _Number = Convert.ToInt32(Number);
            string name = "";
            switch (_Number)
            {
                case 1:
                    name = "Un";
                    break;
                case 2:
                    name = "Deux";
                    break;
                case 3:
                    name = "Trois";
                    break;
                case 4:
                    name = "Quatre";
                    break;
                case 5:
                    name = "Cing";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Sept";
                    break;
                case 8:
                    name = "Huit";
                    break;
                case 9:
                    name = "Neuf";
                    break;
            }
            return name;
        }

        //10 -> 19 && hàng chục 20 -> 90
        public static string douzaines(string Number)
        {
            int _Number = Convert.ToInt32(Number);
            string name = null;
            switch (_Number)
            {
                case 10:
                    name = "Dix";
                    break;
                case 11:
                    name = "Onze";
                    break;
                case 12:
                    name = "Douze";
                    break;
                case 13:
                    name = "Treize";
                    break;
                case 14:
                    name = "Quatorze";
                    break;
                case 15:
                    name = "Quinze";
                    break;
                case 16:
                    name = "Seize";
                    break;
                case 17:
                    name = "Dix-Sept";
                    break;
                case 18:
                    name = "Dix-Huit";
                    break;
                case 19:
                    name = "Dix-Neuf";
                    break;
                case 20:
                    name = "Vingt";
                    break;
                case 30:
                    name = "Trente";
                    break;
                case 40:
                    name = "Quarante";
                    break;
                case 50:
                    name = "Cingquante";
                    break;
                case 60:
                    name = "Soixante";
                    break;
                case 70:
                    name = "Soixante-Dix";
                    break;
                case 80:
                    name = "Quatre-Vingts";
                    break;
                case 90:
                    name = "Quatre-Vingts-Dix";
                    break;
                default:
                    if (_Number > 0)
                    {
                        name = douzaines(Number.Substring(0, 1) + "0") + " " + unites(Number.Substring(1));
                    }
                    break;
            }
            return name;
        }


        // chuyễn số sang Tiếng Pháp - new
        public string NumberToFrench(string Number)
        {
            string word = "";
            try
            {   
                bool isDone = false;//test if already translated    
                double dblAmt = (Convert.ToDouble(Number));
                int numDigits; // độ dài chữ số
                if (dblAmt > 0)
                {
                    int pos = 0; //store digit grouping  // vị trí để tách các số trong nhóm đơn vị lớn nhất với các nhóm đơn vị còn lại của số truyền vào
                    numDigits = Number.Length;            // 100. 000 000

                    string place = "";//digit grouping name:hundres,thousand,etc...    
                    switch (numDigits)
                    {
                        case 1://unites's range    

                            word = unites(Number);
                            isDone = true;
                            break;
                        case 2://douzaines's range    
                            word = douzaines(Number);
                            isDone = true;
                            break;
                        case 3://cent's range                   // #. ##
                            pos = (numDigits % 3) + 1;          // chia lấy dư cho số chữ số nhỏ nhất ở trong nhóm đơn vị đó rồi + 1
                            place = " Cent ";
                            break;
                        case 4://milles's range                 // #.###
                        case 5:                                // ##.###
                        case 6:                             
                            pos = (numDigits % 4) + 1;        //###. ### -  chia lấy dư cho số chữ số nhỏ nhất ở trong nhóm đơn vị đó rồi + 1
                            place = " Mille ";            
                                                           
                            break;
                        case 7://millions's range    
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million ";
                            break;
                        case 10://milliards's range    
                        case 11:
                        case 12:
                            pos = (numDigits % 10) + 1;
                            place = " Milliard ";
                            break;
                        case 13://billions's range    
                        case 14:
                        case 15:
                            pos = (numDigits % 13) + 1;
                            place = " Billion ";
                            break;
                        case 16://mile billions's range    
                        case 17:
                        case 18:
                            pos = (numDigits % 16) + 1;
                            place = " Mille Billions ";
                            break;
                        case 19://trillions's range    
                        case 20:
                        case 21:
                            pos = (numDigits % 19) + 1;
                            place = " Trillion ";
                            break;
                        case 22://mile trillions's range    
                        case 23:
                        case 24:
                            pos = (numDigits % 22) + 1;
                            place = " Mille Trillions ";
                            break;
                        case 25://quatrillion's range    
                        case 26:
                        case 27:
                            pos = (numDigits % 25) + 1;
                            place = " Quatrillion ";
                            break;
                        case 28://mille quatrillions's range    
                        case 29:
                        case 30:
                            pos = (numDigits % 28) + 1;
                            place = " Mille Quatrillions ";
                            break;
                        case 31://quintillion's range    
                        case 32:
                        case 33:
                            pos = (numDigits % 31) + 1;
                            place = " Quintillion ";
                            break;
                        case 34://mille quintillions's range    
                        case 35:
                        case 36:
                            pos = (numDigits % 34) + 1;
                            place = " Mille Quintillions ";
                            break;
                        case 37://Sextillion's range    
                        case 38:
                        case 39:
                            pos = (numDigits % 37) + 1;
                            place = " Sextillion ";
                            break;
                        case 40://mille sextillions's range    
                        case 41:
                        case 42:
                            pos = (numDigits % 40) + 1;
                            place = " Mille Sextillions ";
                            break;
                        case 43://million de sextillions's range    
                        case 44:
                        case 45:
                            pos = (numDigits % 43) + 1;
                            place = " Million De Sextillions ";
                            break;
                        case 46://mille millions de sextillions's range    
                        case 47:
                        case 48:
                            pos = (numDigits % 46) + 1;
                            place = " Mille Millions De Sextillions ";
                            break;
                        case 49://billion de sextillions's range    
                        case 50:
                        case 51:
                            pos = (numDigits % 49) + 1;
                            place = " Billion De Sextillions ";
                            break;
                        case 52://mille billions de sextillions's range    
                        case 53:
                        case 54:
                            pos = (numDigits % 52) + 1;
                            place = " Mille Billions De Sextillions ";
                            break;
                        case 55://trillion de sextillions's range    
                        case 56:
                        case 57:
                            pos = (numDigits % 55) + 1;
                            place = " Trillion De Sextillions ";
                            break;
                        case 58://mille trillions de sextillions's range    
                        case 59:
                        case 60:
                            pos = (numDigits % 58) + 1;
                            place = " Mille Trillions De Sextillions ";
                            break;
                        case 61://quatrillion de sextillions's range    
                        case 62:
                        case 63:
                            pos = (numDigits % 61) + 1;
                            place = " Quatrillion De Sextillions ";
                            break;
                        case 64://mille quatrillions de sextillions's range    
                        case 65:
                        case 66:
                            pos = (numDigits % 64) + 1;
                            place = " Mille Quatrillions De Sextillions ";
                            break;
                        case 67://Unvigintillion's range    
                        case 68:
                        case 69:
                            pos = (numDigits % 67) + 1;
                            place = " Unvigintillion";
                            break;
                        case 70://quintillion de sextillions's range    
                        case 71:
                        case 72:
                            pos = (numDigits % 70) + 1;
                            place = " Quintillion De Sextillions ";
                            break;
                        case 73://mille quintillions de sextillions's range    
                        case 74:
                        case 75:
                            pos = (numDigits % 73) + 1;
                            place = " Mille Quintillions De Sextillions ";
                            break;
                        //add extra case options for anything above Billion...    
                        default:
                            isDone = true;
                            break;
                    }
                  
                    if (!isDone)
                    {    // ###. ###  ### 123. 000. 321
                          // 000. 321
                         //if transalation is not done, continue...(Recursion comes in now!!)    
                         //3.00
                        if (Convert.ToInt32(Number.Substring(0, pos)) != 0 && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                //123 + mille + 321
                                word = NumberToFrench(Number.Substring(0, pos)) + place + NumberToFrench(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = NumberToFrench(Number.Substring(0, pos)) + NumberToFrench(Number.Substring(pos)); 
                            //check for trailing zeros    
                        }
                    }
                }
            }
            catch { }
            return word;
        }
        

        //Chuyển sang tiếng Anh
        public static string ones(string Number)
        {
            int _Number = Convert.ToInt32(Number);
            string name = "";
            switch (_Number)
            {
                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }
        public static string tens(string Number)
        {
            int _Number = Convert.ToInt32(Number);
            string name = null;
            switch (_Number)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (_Number > 0)
                    {
                        name = tens(Number.Substring(0, 1) + "0") + " " + ones(Number.Substring(1));
                    }
                    break;
            }
            return name;
        }
        public string NumberToEnglish(string Number)
        {
            string word = "";
            try
            {
                bool isDone = false;//test if already translated    
                double dblAmt = (Convert.ToDouble(Number)); 
                int numDigits;
                if (dblAmt > 0)
                {
                    numDigits = Number.Length;
                    int pos = 0;//store digit grouping    
                    string place = "";//digit grouping name:hundres,thousand,etc...    
                    switch (numDigits)
                    {
                        case 1://ones's range    
                            word = ones(Number);
                            isDone = true;
                            break;
                        case 2://tens's range    
                            word = tens(Number);
                            isDone = true;
                            break;
                        case 3://hundredss's range    
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4://thousands's range    
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        case 7://millions's range    
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million ";
                            break;
                        case 10://Billions's range    
                        case 11:
                        case 12:
                            pos = (numDigits % 10) + 1;
                            place = " Billion ";
                            break;
                        case 13://Tillions's range    
                        case 14:
                        case 15:
                            pos = (numDigits % 13) + 1;
                            place = " Trillion ";
                            break;
                        case 16://Quadrillions's range    
                        case 17:
                        case 18:
                            pos = (numDigits % 16) + 1;
                            place = " Quadrillion ";
                            break;
                        case 19://Quintillians's range    
                        case 20:
                        case 21:
                            pos = (numDigits % 19) + 1;
                            place = " Quintillian ";
                            break;
                        case 22://Sextillions's range    
                        case 23:
                        case 24:
                            pos = (numDigits % 22) + 1;
                            place = " Sextillion ";
                            break;
                        case 25://Septillion's range    
                        case 26:
                        case 27:
                            pos = (numDigits % 25) + 1;
                            place = " Septillion ";
                            break;
                        case 28://Ocillions's range    
                        case 29:
                        case 30:
                            pos = (numDigits % 28) + 1;
                            place = " Octillion ";
                            break;
                        case 31://Nonillions's range    
                        case 32:
                        case 33:
                            pos = (numDigits % 31) + 1;
                            place = " Nonillion ";
                            break;
                        case 34://Decillions's range    
                        case 35:
                        case 36:
                            pos = (numDigits % 34) + 1;
                            place = " Decillion ";
                            break;
                        case 37://Undecillion's range    
                        case 38:
                        case 39:
                            pos = (numDigits % 37) + 1;
                            place = " Undecillion ";
                            break;
                        case 40://Duodecillion's range    
                        case 41:
                        case 42:
                            pos = (numDigits % 40) + 1;
                            place = " Duodecillion ";
                            break;
                        case 43://Decillions's range    
                        case 44:
                        case 45:
                            pos = (numDigits % 43) + 1;
                            place = " Tredecillion ";
                            break;
                        case 46://Quattuordecillion's range    
                        case 47:
                        case 48:
                            pos = (numDigits % 46) + 1;
                            place = " Quattuordecillion ";
                            break;
                        case 49://Quindecillion's range    
                        case 50:
                        case 51:
                            pos = (numDigits % 49) + 1;
                            place = " Quindecillion ";
                            break;
                        case 52://Sexdecillion's range    
                        case 53:
                        case 54:
                            pos = (numDigits % 52) + 1;
                            place = " Sexdecillion ";
                            break;
                        case 55://Septendecillion's range    
                        case 56:
                        case 57:
                            pos = (numDigits % 55) + 1;
                            place = " Septendecillion ";
                            break;
                        case 58://Octodecillion's range    
                        case 59:
                        case 60:
                            pos = (numDigits % 58) + 1;
                            place = " Octodecillion ";
                            break;
                        case 61://Novemdecillion's range    
                        case 62:
                        case 63:
                            pos = (numDigits % 61) + 1;
                            place = " Novemdecillion ";
                            break;
                        case 64://Vigintillion's range    
                        case 65:
                        case 66:
                            pos = (numDigits % 64) + 1;
                            place = " Vigintillion ";
                            break;
                        case 67://Unvigintillion's range    
                        case 68:
                        case 69:
                            pos = (numDigits % 67) + 1;
                            place = " Unvigintillion";
                            break;
                        case 70://Douvigintillion's range    
                        case 71:
                        case 72:
                            pos = (numDigits % 70) + 1;
                            place = " Douvigintillion ";
                            break;
                        case 73://Trevigintillion's range    
                        case 74:
                        case 75:
                            pos = (numDigits % 73) + 1;
                            place = " Trevigintillion ";
                            break;
                        //add extra case options for anything above Billion...    
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone) //  
                    {
                                                                         //1000257
                        //if transalation is not done, continue...(Recursion comes in now!!)    
                        if (Convert.ToInt32(Number.Substring(0, pos)) != 0 && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = NumberToEnglish(Number.Substring(0, pos)) + place + NumberToEnglish(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = NumberToEnglish(Number.Substring(0, pos)) + NumberToEnglish(Number.Substring(pos));
                        }
                    }
                    //ignore digit grouping names    
                    if (word.Trim().Equals(place.Trim()))
                        word = "";
                }
            }
            catch { }
            return word;
        }
     
       
        public string DeleteDotInNumber(string s)
        {
            string rs = s;
            int pos = 0;
            foreach (char c in s.ToArray())
            {
                // xóa dấu chấm
                if (c.Equals('.'))
                {
                    rs = rs.Remove(pos, 1);
                    pos--;
                }
                //xóa phần byte đằng sau
                if (c.Equals('\0'))
                {
                    rs = rs.Remove(pos);
                    break;
                }
                pos++;
            }
            return rs;
        }
    }
}




