CREATE PROCEDURE Sp_employee_payroll_Insert 
	-- Add the parameters for the stored procedure here
	@EmpName varchar(100),
	@Gender char(10),
	@BasicPay varchar(100),	
	@PhoneNumber varchar(10),
	@Address varchar(200),
	@Deduction varchar(100),	
	@TaxablePay	 varchar(100),
	@IncomeTax varchar(100),	
	@NetPay	varchar(100),
	@Department varchar(100)
AS
BEGIN
	insert into employee_payroll values(@EmpName,@Gender,@BasicPay,@PhoneNumber,@Address,@Deduction,
										@TaxablePay,@IncomeTax,@NetPay,@Department)
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EmpName,Gender,BasicPay,PhoneNumber,Address,Deduction,
			TaxablePay,IncomeTax,NetPay,@Department FROM employee_payroll;
END
GO

CREATE PROCEDURE Sp_employee_payroll_Update 
	-- Add the parameters for the stored procedure here
	@EmpName varchar(100),
	@Gender char(10),
	@BasicPay varchar(100),	
	@PhoneNumber varchar(10),
	@Address varchar(200),
	@Deduction varchar(100),	
	@TaxablePay	 varchar(100),
	@IncomeTax varchar(100),	
	@NetPay	varchar(100),
	@Department varchar(100)
AS
BEGIN
	update employee_payroll set EmpName=@EmpName,Gender=@Gender,BasicPay=@BasicPay,PhoneNumber=@PhoneNumber,Address=@Address,
		Deduction=@Deduction,TaxablePay=@TaxablePay,IncomeTax=@IncomeTax,NetPay=@NetPay,@Department=@Department 
		where EmpName=@EmpName
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EmpName,Gender,BasicPay,PhoneNumber,Address,Deduction,
		   TaxablePay,IncomeTax,NetPay,@Department FROM employee_payroll;
END
GO

Create PROCEDURE Sp_employee_payroll_Delete
	-- Add the parameters for the stored procedure here
	@EmpName varchar(100),
	@Gender char(10),
	@BasicPay varchar(100),	
	@PhoneNumber varchar(10),
	@Address varchar(200),
	@Deduction varchar(100),	
	@TaxablePay	 varchar(100),
	@IncomeTax varchar(100),	
	@NetPay	varchar(100),
	@Department varchar(100)
AS
BEGIN
	delete from employee_payroll where EmpName = @EmpName
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EmpName,Gender,BasicPay,PhoneNumber,Address,Deduction,
		   TaxablePay,IncomeTax,NetPay,Department FROM employee_payroll;
END
GO

Alter PROCEDURE Sp_employee_payroll_ViewRecord 
	-- Add the parameters for the stored procedure here
	@EmpName varchar(100),
	@Gender char(10),
	@BasicPay varchar(100),	
	@PhoneNumber varchar(10),
	@Address varchar(200),
	@Deduction varchar(100),	
	@TaxablePay	 varchar(100),
	@IncomeTax varchar(100),	
	@NetPay	varchar(100),
	@Department varchar(100)
AS
BEGIN
	SELECT * FROM employee_payroll;
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EmpName,Gender,BasicPay,PhoneNumber,Address,Deduction,
		   TaxablePay,IncomeTax,NetPay,Department FROM employee_payroll;
END
GO