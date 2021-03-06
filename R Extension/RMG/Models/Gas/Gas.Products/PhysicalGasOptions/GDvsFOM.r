############################### Gas Daily Daily Option ####################################
# Examples at the end of the file.

# exercise= "always" Economic means  they decide when to exercise economically. If a GDD, this will produce no difference. If exercised against the FOM index, an economic exercise will cause the CP to only call it when the GD price > FOM
# numExercises=20, period = "month",  # number of times buyer can call for gas delivery per "month" or in entire "term"
# deal.index is the symbol of a given index (e.g. IGBBL00 for NYMEX)
# deal.start and deal.end are the start and end dates for this deal: "mm/dd/yyyy"
# fixed.volume = TRUE. Whether it is a fixed volume or flexible
# deal.volume.high (or .low) is the daily volume limit
# num.years = 3. The number of years of historical data to estimate required parameters.
# intraday.dist ="Uniform" or "triangular"
# noSims: number of MC simulations
# spot.vol: historical daily spot volatilities for each calendar Month.
# directory : where all R functions are saved.
# strike = "FOMIndex", strike.adder.1 = 0, strike.adder.2 = 0, strike.adder.3 = 0, fuel = 0,  are various quantities that alter the strike. Fuel is in % points, e.g. .05 =5%
# deal.Index = "IGBBL00"
# numPaths is the number of spot price paths to be plotted
# estm.vol="historical"  or "user" provided
# ToPlot.ratios=FALSE,
# Verbose refers to the messages R puts out

GDD.evaluate <- function(
             exercise= "always", numExercises=20, period = "month",  # number of times buyer can call for gas delivery per "month" or in entire "term"
             deal.start = "11/1/2006",deal.end = "3/31/2007",
             fixed.volume = TRUE, deal.volume.high=50000, deal.volume.low=10000,
             strike = "FOMIndex", strike.adder.1 = 0, strike.adder.2 = 0, strike.adder.3 = 0, fuel = 0,
             deal.Index = "IGBBL00", num.years=3, intraday.dist ="Uniform", noSims=100, numPaths=4,
             spot.vol, estm.vol="historical",
             directory="H:\\user\\R\\RMG\\Models\\Gas\\Gas.Products\\PhysicalGasOptions\\", ToPlot.ratios=FALSE,
             ccg.fc = "COMMOD NG EXCHANGE", column = "Index", custom = "not specified", cusFlag = "NO", wkdir="H:\\", Verbose = T) {
             
  #Remove old results from disk (Excel will pull them in indiscriminately even if they are old)
  if(file.exists(paste(wkdir,"ExpectedPayoff.jpg", sep=""))) file.remove(paste(wkdir,"ExpectedPayoff.jpg", sep=""))
  if(file.exists(paste(wkdir,"SimPrices.jpg", sep=""))) file.remove(paste(wkdir,"SimPrices.jpg", sep=""))

  # Type of exercise
  if(Verbose) {
    print(paste("Exercised",exercise , ". Max number of exercises is ",numExercises, "per", period, sep=" "))
  }

  # Deal Term
  deal.start = as.Date(deal.start, "%m/%d/%Y")
  deal.end = as.Date(deal.end, "%m/%d/%Y")
  deal.length = as.numeric(as.Date(deal.end) - as.Date(deal.start))+1
  if(Verbose) {
    print(paste("Deal starts on",deal.start, "and ends on", deal.end, ". Deal duration is:", deal.length, "days.", sep=" "))
  }

  # Volumes
  if(fixed.volume){
    volume.type="Fixed"
    if (deal.volume.low!=deal.volume.high) {
        print(paste("High Volume = ", deal.volume.high))
        print(paste("Low Volume = ", deal.volume.low))
        warning("High and Low volumes are different suggesting swing while volume type was given as fixed!")
    }
    deal.volume <- deal.volume.high
    print(paste("Volume is", volume.type, "and set at", deal.volume, sep=" "))
    deal.contracts = deal.volume/10000         # YT Correction: Used to be hardwired as "50000/10000"
    deal.contracts.high = deal.volume.high/10000
    deal.contracts.low = deal.volume.low/10000
 }else{
    volume.type="Flexible"
    print(paste("Volume is", volume.type, "and can swing from", deal.volume.low, "to", deal.volume.high, sep=" "))
    deal.contracts.high = deal.volume.high/10000
    deal.contracts.low = deal.volume.low/10000
 }                                           

  if(Verbose) {
    # Strike details
    print(paste("strike:",strike , sep=" "))
    print(paste("strike.adder.1:",strike.adder.1 , sep=" "))
    print(paste("strike.adder.2", strike.adder.2, sep=" "))
    print(paste("fuel", fuel, sep=" "))
    print(paste("column", column, sep=" "))

    # Data
    print(paste("deal.Index:",deal.Index , sep=" "))
    print(paste("num.years:",num.years , sep=" "))
    print(paste("intraday.dist:",intraday.dist , sep=" "))
    print(paste("noSims:",noSims , sep=" "))
    print(paste("estm.vol", estm.vol, sep=" "))

    # Location of R code on disk
    print(paste("directory", directory, sep=" "))
    print(paste("custom", custom, sep=" "))
    print(paste("cusFlag", cusFlag, sep=" "))
    # Forward Curve Name
    print(paste("ccg.fc", ccg.fc, sep=" "))
  }                                                               

  # Obtain historical Index, High and Low prices for Henry Hub
  if  (cusFlag  == "NO") {
  print("using index") 
  source(paste(directory,"get.Index.r", sep=""))
  hist.index <- get.Index(Index=deal.Index ,
                time.period=list(start.mm.dd=format(as.Date(deal.start),"%m/%d"), end.mm.dd=format(as.Date(deal.end), "%m/%d") ,
                start.year=as.numeric(format(Sys.Date(), "%Y"))-num.years),
                Verbose=FALSE)
  }
  else {
  print("using custom index")
  column <- "Index"
  source(paste(directory,"get.Custom.Index.r", sep=""))
  hist.index <- get.Custom.Index(Index=custom ,
                time.period=list(start.mm.dd=format(as.Date(deal.start),"%m/%d"), end.mm.dd=format(as.Date(deal.end), "%m/%d") ,
                start.year=as.numeric(format(Sys.Date(), "%Y"))-num.years),
                Verbose=FALSE)
  }

  # Obtain current fwrd curve as of last trading date
  months.in.term = unique(format(as.Date(rownames(hist.index)),"%b"))
  
  #source(paste(directory, "get.hist.FwdCurve.r", sep=""))
  #current.FC <- get.hist.FwdCurve(commodity1="Close of NG",start.mo.FC=format(deal.start,"%m"),
  #                                  start.year.FC=format(deal.start,"%Y"), num.months=length(months.in.term),
  #                                  start.date.hist=format(Sys.Date()-10, "%m/%d/%Y"), Verbose=FALSE, ShowPrices=TRUE)[[3]]

  source(paste(directory, "get.hist.FwdCurve.from.CPSPROD.r", sep=""))
  current.FC <- get.hist.FwdCurve.from.CPSPROD(commodity1=ccg.fc,start.mo.FC=format(deal.start,"%m"),
                                    start.year.FC=format(deal.start,"%Y"), num.months=length(months.in.term),
                                    start.date.hist=format(Sys.Date()-10, "%m/%d/%Y"), Verbose=FALSE, ShowPrices=TRUE)[[3]]
  
  print(paste(months.in.term, ":", round(current.FC,3)))
  
  # Find if we have a leap February - needed later.
  if (sum(apply(matrix(names(current.FC),nc=1),1,Uts.String.left,1)=="G")> 0)
    if(as.integer(Uts.String.right(names(current.FC)[apply(matrix(names(current.FC),nc=1),1,Uts.String.left,1)=="G"],2))%%4==0) FebDays<-29 else FebDays<-28
  else FebDays<-28



  # Obtain the historical correlations and spot volatility
  source(paste(directory, "FEA.spot.prompt.analysis.r", sep=""))
  corr.vol.data <- monthly.vol.corr(Index= paste("Index of ",deal.Index, sep="") , Prompt="Close of NG",
                                    start.date.hist=paste("01/01/",as.numeric(format(Sys.Date(), "%Y"))-num.years , sep=""),
                                    Verbose=FALSE, Plot=F, directory=directory)

  # Create MarketData and options  to simulate spot prices
  MarketData <- options <- NULL

  options$noSims <- noSims    # Number of simulations
  options$nodays <-  deal.length
  options$nopaths <- numPaths    # Number of paths to be plotted

  MarketData$mr <- corr.vol.data[[1]]  # mr = mean reversion rate
  MarketData$SP.corr <- corr.vol.data[[2]][,ncol(corr.vol.data[[2]])]
  MarketData$Spot.vol <- corr.vol.data[[3]][,ncol(corr.vol.data[[3]])]

  if (estm.vol=="historical"){
    MarketData$Spot.vol <- corr.vol.data[[3]][,ncol(corr.vol.data[[3]])]
    print("Using historically estimated volatilities")
    print(round(MarketData$Spot.vol,2))
    }else{
        print("Using user estimates for volatilities")
        print(paste(c("Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"),spot.vol , sep=": "))
        MarketData$Spot.vol <- spot.vol
    }

  MarketData$last.spot <- corr.vol.data[[4]][nrow(corr.vol.data[[4]]),1]
  MarketData$last.fwd <- corr.vol.data[[4]][nrow(corr.vol.data[[4]]),2]
  MarketData$AsOf <- as.Date(rownames(corr.vol.data[[4]])[nrow(corr.vol.data[[4]])])
  MarketData$Pricing.dates <- seq(as.Date(deal.start, format="%Y-%m-%d"),by="day",length.out=deal.length)
  MarketData$current.FC <- current.FC

  # Simulate Daily Index Prices
  jpeg(paste(wkdir, "SimPrices.jpg", sep=""), width = 640, height = 520)
  sim.spots <- simulate.spots.FEA(MarketData, options, RemoveWkd=FALSE)
  dev.off()

  # Step II: Simulate from Historical Low and high prices for Henry Hub during the term of this contract
  
  # Separate by month
  high.ratio <- NULL
  low.ratio <- NULL
  for(i in 1:length(months.in.term)){
    entry= which(format(as.Date(rownames(hist.index)),"%b" )==months.in.term[i])
    high.ratio[[i]] = hist.index[entry,2]/hist.index[entry,1]  # The min value of high.ratio is 1
    low.ratio[[i]] =  hist.index[entry,3]/hist.index[entry,1]  # The max value of low.ratio is 1

    if(ToPlot.ratios){
      windows()
      par(mfrow=c(2,2))
      hist(high.ratio[[i]], main=paste("Histogram of High/Index for ",months.in.term[i],sep=""))
      plot(density(high.ratio[[i]]), main=paste("Density of High/Index for ",months.in.term[i],sep=""))
      hist(low.ratio[[i]], main=paste("Histogram of Low/Index for ",months.in.term[i],sep=""))
      plot(density(low.ratio[[i]]), main=paste("Density of Low/Index for ",months.in.term[i], sep=""))
    }
  }

  # Simulate high and low values for each month

  # Build a blank margin table of rows as many as the pricing dates and columns as many as the simulations
  margin <- matrix(NA, nc=options$noSims, nr=length(MarketData$Pricing.dates))  # rows are dates; each col is another simulation
  # Build a blank FOM Index table of rows as many as the pricing dates and columns as many as the simulations
  FOMIndices <- matrix(NA, nc=options$noSims, nr=length(MarketData$Pricing.dates))     # this is a representation of the FC; each col is a flat-for-the-month FC. All columns are equal
  monthsInDeal <- nonClusteringElements(format(as.Date(MarketData$Pricing.dates),"%b"))
  NumDaysInCalMos <- data.frame(c("Jan", "Feb", "Mar","Apr","May","Jun","Jul", "Aug","Sep","Oct", "Nov", "Dec") ,c(31,FebDays,31,30,31,30,31,31,30,31,30,31))
  FOMIndex <- rep(MarketData$current.FC,NumDaysInCalMos[match(monthsInDeal,NumDaysInCalMos[,1]),2])    # One simulation
  for (i in 1:options$noSims){ FOMIndices[,i] <-  FOMIndex  }

  for (d in 1:length(MarketData$Pricing.dates)){
    entry = which(months.in.term==format(as.Date(MarketData$Pricing.dates[d]),"%b"))    # if Jan,Feb,Mar, Nov,Dec is the set of months in term and the deal starts with Nov, the results here will be "4" (i.e. the 4th month of the months.in.term array
    sim.high = sim.spots[d,]*sample(high.ratio[[entry]], options$noSims, replace = TRUE)
    sim.low = sim.spots[d,]*sample(low.ratio[[entry]], options$noSims, replace = TRUE)

    if(intraday.dist =="Triangular"){
    source("H:/user/R/RMG/Models/Gas/Gas.Products/PhysicalGasOptions/TriangDist.r")
    apply.triang <- function(i, n, sim.low, sim.mode, sim.high){ rtriang(n, min.val=sim.low[i], mode.val=sim.mode[i], max.val=sim.high[i])}

    # Using a triangular distribution for intraday distribution is less conservative than Uniform distr.
        intraday <- apply(matrix(1:options$noSims), 1, apply.triang, n=1, sim.low=sim.low, sim.mode=sim.spots[d,], sim.high=sim.high)
    }else{
    # Using a Uniform draw is more conservative.
        intraday = runif(options$noSims,sim.low,sim.high)
    }
    
    if(column=="Index") {
        sim.price = sim.spots[d,]
        
    }
    else if (column=="Avg Index & Max") {
        sim.price = (sim.spots[d,] + sim.high)/2
        
    }
    else {
        sim.price = (sim.spots[d,] + sim.low)/2
        
    }
    #MARGIN
    #... under all circumstances
    # Strike adder 1 is a $ charge per mmbtu of exercised flow
    # Strike adder 2 is a $ charge per mmbtu of capacity.
    if(strike=="DailyIndex") {
        margin[d,] = sim.price - intraday + strike.adder.1 + sim.price*fuel
    } else {
      if(exercise=="sometimes") {    # i.e. exercised SOMETIMES, presumably when economic
        the.strike <- FOMIndices[d,] + strike.adder.1 + sim.price*fuel
        margin[d,] =  ifelse(sim.price>the.strike, the.strike-sim.price, 0)
      } else {        # i.e. exercised ALWAYS
        the.strike <- FOMIndices[d,] + strike.adder.1 + sim.price*fuel
        margin[d,] =  the.strike-sim.price
      }
    }
  } # End of for loop on the pricing dates


    # ... corrections for  limit on number of exercises
  for (ipath in 1:options$noSims) {

    if(exercise != "always" & strike == "FOMIndex") {       #limited exercises, let's deal with it
        if (period=="Month") {      # limited exercises are expressed as number per month
            # THIS SCENARIO (limited exercises in a month)IS NOT DONE BELOW  **** LOOK HERE !!! ****
#            print(margin[,ipath])
            margin[,ipath]<-get.n.lowest.margins.from.each.month(x=data.frame(margin[,ipath],format(as.Date(MarketData$Pricing.dates),"%b")),n=numExercises)
#            print(round(margin[,ipath],2))
        } else {                    # limited exercises are expressed as number during the deal term
            # Keep the numExercises worst margins; set the rest to zero
#            if(ipath==1& Verbose) print(round(margin,2))
            margin[order(margin[,ipath])[(numExercises+1):length(margin[,ipath])], ipath] <- NA
#            if(ipath==1 & Verbose) print(round(margin,2))
        }
    } else {
        numExercises <- deal.length
    }
  }
  # Omit the NAs from the margin.  Those emerge from days the CP did not exercise and exist only in peaker options
  margin <- as.data.frame(apply(margin,2,na.omit))    # must omit NAs in each column (simulation) separately LOOK HERE

    # Add capacity charges to the margin
    capacity.charges.total <- numExercises * strike.adder.2 * deal.volume.high

    # ... if there is swing (i.e. Volume is not constant), maximize volume on negative days
    if(fixed.volume) {    # Volume is fixed
        tot.margin <- margin * deal.volume
        tot.margin <- (apply(tot.margin,2,sum) + capacity.charges.total)
        deal.margin <- tot.margin /(deal.volume*numExercises)
    } else {              # Volume has swing: all days get a random volume
        random.volume <- matrix( 10000*sample(deal.contracts.low:deal.contracts.high,options$noSims*length(MarketData$Pricing.dates),  replace = TRUE), nc=options$noSims, nr=length(MarketData$Pricing.dates))
        # for negative margins, volume is max (i.e. deal.volume)
        for( k in 1:length(MarketData$Pricing.dates)){random.volume[k,which(margin[k,]<0)] <- deal.volume.high}
        tot.margin <- margin*random.volume
        tot.margin <- apply(tot.margin,2,sum) + capacity.charges.total
        deal.margin <- tot.margin/apply(random.volume,2,sum)
    }                     # End Volume has swing
#        tot.margin<<-tot.margin
#        deal.margin<<-deal.margin   

   # Statistics
    deal.summary.per.MMBTU.served <- t(cbind(names(summary(deal.margin)),summary(deal.margin)) )
    deal.summary <-  t(summary(tot.margin)) 
    the.probs <- c(0., 0.005, seq(0.01,.15, .01), seq(.20, .5,.1), .67, seq(.70, 1,.1) )
    margin.quantiles.per.MMBTU.served <- (cbind(names(quantile(deal.margin, probs=the.probs)), round(quantile(deal.margin, probs=the.probs),4)))
    margin.quantiles <- round(quantile(tot.margin, probs=the.probs),4)
    

    jpeg(paste(wkdir, "ExpectedPayoff.jpg", sep=""), width = 640, height = 520)
    par(mfrow=c(2,1))
    hist(deal.margin, breaks = min(20, noSims),
        xlab="", main ="Distribution of Margin/MMBtu",
        sub=paste(intraday.dist," Intraday Dist and ", volume.type, " Volume", sep=""), col.main="Blue",
        col="lightblue", border="pink")
    boxplot(deal.margin, main ="Box-Plot of Margin/MMBtu", col.main="Blue", col="orange")
    dev.off()
    
   results <- list("StatSummary"= deal.summary, "PerMMBTUServedSummary" = deal.summary.per.MMBTU.served, 
                  "Margin.Quantiles"= margin.quantiles, "Margin.Quantiles.per.MMBTU.served"= margin.quantiles.per.MMBTU.served)
   results <<- results
   return(results)
}    

#       UTILITIES

nonClusteringElements <- function (x) {
    result <- x[1]
    for (i in 2: length(x)) {
        if(x[i]!=x[i-1]) {result <- append (result,x[i])}
    }
    result
}

# Find the n lowest margins in each month, where n is the number of exercises per month
# and set the rest of the margins to 0 (implying that they are not exercised)
# Example;
# get.n.lowest.margins.from.each.month(x=data.frame(margin[,1],format(as.Date(MarketData$Pricing.dates),"%b")), n=20)
# x is a data frame of two columns, the first one of margins (reals) and the second one of months (e.g. "Mar", "Mar",...)
# n is the number of exercises in a month.  All other margins in that month will be set to zero.
get.n.lowest.margins.from.each.month <- function(x,n){
    #unstack(margin,form=formula(margin$Margin ~ margin$Month))
    x[,2] <- as.character(x[,2])                                                   
    res <- vector(mode="numeric",0)
    the.months <- unique(x[,2])
    for (i in 1:length(the.months)) {
        this.mo.vec <- x[which(x[,2]==the.months[i]),1]
        this.mo.len <- length(this.mo.vec)
        eliminate.these.elem <- order(this.mo.vec)[(n+1):this.mo.len]
        this.mo.vec[ eliminate.these.elem ] <- NA
        res<- append(res,  this.mo.vec )
    }
#    print(res)
    return(res)
}

# EXAMPLES OF DEALS VALUED WITH THIS MODEL
# CCG sells UTILITY a Gas Daily Daily Option
# Type: Call
# Term: 11/1/2006 to 3/31/2007
# Volume: Fixed daily at 50,000 MMBtu/day
# Index: Henry Hub
# CCG receives Index + $0.02
# UTILITY will notify CCG between 7:30am-8:00am CST on day prior to delivery.
# Margin = (Index +0.02 - Trader's purchasing price)*volume
