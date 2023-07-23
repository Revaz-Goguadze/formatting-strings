namespace FormattingStrings
{
    public static class Interpolation
    {
        public static string GetDepositCsv(int id, string name, string iban, decimal deposit, decimal balance, double interestRate)
        {
            FormattableString csv = $@"{id},""{name}"",{balance:F2},""{interestRate:P2}"",""{deposit:C4}"",{iban}";
            return FormattableString.Invariant(csv);
        }

        public static string GetProductCsv(int id, string name, int supplierId, int categoryId, string quantityPerUnit, double unitPrice, int unitInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            FormattableString csv = $@"{id},""{name}"",{supplierId},""{categoryId}"",{quantityPerUnit},""{unitPrice:F2}"",{unitInStock},""{unitsOnOrder}"",{reorderLevel},""{discontinued}""";
            return FormattableString.Invariant(csv);
        }


        public static string GetDepositJson(int id, string name, string iban, decimal deposit, decimal balance, double interestRate)
        {
            // TODO #4-3. Analyze the method unit tests and implement the method.
            throw new NotImplementedException();
        }

        public static string GetProductXml(int id, string name, int supplierId, int categoryId, string quantityPerUnit, double unitPrice, int unitInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            // TODO #4-4. Analyze the method unit tests and implement the method.
            throw new NotImplementedException();
        }

        public static string GetDepositTable(int id, string name, string iban, decimal deposit, decimal balance, double interestRate)
        {
            // TODO #4-5. Analyze the method unit tests and implement the method.
            throw new NotImplementedException();
        }

        public static string GetProductList(int id, string name, int supplierId, int categoryId, string quantityPerUnit, double unitPrice, int unitInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            // TODO #4-6. Analyze the method unit tests and implement the method.
            throw new NotImplementedException();
        }
    }
}
