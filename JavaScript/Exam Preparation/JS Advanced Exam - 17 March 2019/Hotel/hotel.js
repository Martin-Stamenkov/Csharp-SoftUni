class Hotel {

    constructor(name, capacity) {
        this.name = name;
        this.capacity = capacity;
        this.bookings = [];
        this.currentBookingNumber = 1;
        this.roomCapacity = {
            single: Math.floor(+this.capacity / 2),
            double: Math.floor(+this.capacity * 0.30),
            maisonette: Math.floor(+this.capacity * 0.20)
        }

    }

    get roomsPricing() {
        return {
            single: 50, double: 90, maisonette: 135
        }
    }
    get servicesPricing() {
        return {
            food: 10, drink: 15, housekeeping: 25
        }
    }

    rentARoom(clientName, roomType, nights) {
        let result;
        if (this.roomCapacity[roomType] > 0) {
            let clientBooking = {
                clientName: clientName,
                roomType: roomType,
                nights: nights,
                roomNumber: this.currentBookingNumber
            }
            this.bookings.push(clientBooking)
            result = `Enjoy your time here Mr./Mrs. ${clientName}. Your booking is ${this.currentBookingNumber}.`
            this.roomCapacity[roomType]--;
            this.currentBookingNumber++;
            return result
        } else {
            result = `No ${roomType} rooms available!`;

            for (const room in this.roomCapacity) {
                if (this.roomCapacity[roomType] > 0) {
                    result += `Available ${roomType} rooms: ${this.roomCapacity[room]}.`;
                }
            }
            return result;
        }
    }
    roomService(currentBookingNumber, serviceType) {

        let booking = this.bookings.find(x => x.roomNumber === currentBookingNumber);

        if (!booking) {
            return `The booking ${currentBookingNumber} is invalid.`;
        }
        if (!this.servicesPricing.hasOwnProperty(serviceType)) {
            return `We do not offer ${serviceType} service.`;
        }
        if (!booking.hasOwnProperty('services')) {
            booking['services'] = [];
        }
        booking['services'].push(serviceType);

        return `Mr./Mrs. ${booking.clientName}, Your order for ${serviceType} service has been successful.`
    }
    checkOut(currentBookingNumber) {

        let booking = this.bookings.find(x => x.roomNumber === currentBookingNumber);
        if (!booking) {
            return `The booking ${currentBookingNumber} is invalid`;
        } 
            let index = this.bookings.indexOf(booking);
            this.bookings.splice(index, 1);
        
        let totalMoney = booking.nights * this.roomsPricing[booking.roomType];
        this.roomCapacity[booking.roomType]++;
        
        let result = '';
        if (booking.hasOwnProperty(booking.serviceType)) {
            let totalServiceMoney = 0;
            for (const service of booking.services) {
                totalServiceMoney += +this.servicesPricing[service]
            }
            result = `We hope you enjoyed your time here, Mr./Mrs. ${booking.clientName}.
             The total amount of money you have to pay is ${totalMoney + totalServiceMoney} BGN
            . You have used additional room services, costing ${totalServiceMoney} BGN.`
        } else {
            result = `We hope you enjoyed your time here, Mr./Mrs. ${booking.clientName}. The total amount of money you
            have to pay is ${totalMoney} BGN.`
        }

        return result;
    }
    report() {

        if (this.bookings.length === 0) {
            return `${this.name.toUpperCase()} DATABASE:\n--------------------\nThere are currently no bookings.\n`
        } else {
            let result;
            let count = 0;
            result = `${this.name.toUpperCase()} DATABASE:\n--------------------\n`
            for (const book of this.bookings) {
                result += `bookingNumber - ${book.roomNumber}\n`
                result += `clientName - ${book.clientName}\n`
                result += `roomType - ${book.roomType}\n`
                result += `nights - ${book.nights}\n`
                if (book.hasOwnProperty('services')) {
                    result += `services: ${book.services.join(', ')}\n`;
                }
                count++;
                if (count === this.bookings.length) {
                    break;
                }
                result += `----------\n`
            }
            return result.trim();
        }

    }
}
